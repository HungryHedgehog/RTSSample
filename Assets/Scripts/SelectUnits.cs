using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectUnits : MonoBehaviour
{
    public InputManager _InputManager;    
    public Texture UIBoxTexture;
    [Tooltip("Height of the multi select box, note that the box will be projected via it's center")]
    public float CollisionBoxHeight;
    [Tooltip("The Layers on which the selection box for multiselect will be projected on")]
    public LayerMask BoxSelectLayerMask;

    HashSet<UnitController> Units = new HashSet<UnitController>();


    BoxCollider selectionBox;
    readonly float raydistance = Mathf.Infinity;
    PlayerControls controls;

    bool dragAction = false;
    bool multiSelect = false;
    Vector2 p1;

    private void Start()
    {
        controls = _InputManager.GetControls();
        selectionBox = gameObject.AddComponent<BoxCollider>();       
        selectionBox.isTrigger = true;
        selectionBox.enabled = false;

        controls.UI.ClickAction.performed += ctx => clickAction();
        controls.UI.HoldAction.performed += ctx => holdAction();
        controls.UI.HoldAction.canceled += ctx => releaseAction();

        controls.UI.MultiSelectAction.started += ctx => multiSelect = true;
        controls.UI.MultiSelectAction.canceled += ctx => multiSelect = false;
    }

    private void Update()
    {
        if (dragAction)
        {
            Vector3 CornerA = selectionBox.transform.InverseTransformPoint(getPositionInWorld(p1));
            Vector3 CornerB = selectionBox.transform.InverseTransformPoint(getPositionInWorld(controls.UI.CursorPosition.ReadValue<Vector2>()));

            //calculate the box center by using the point vector of CornerA plus half the vector between CornerA and B (half the diagonal)
            selectionBox.center = CornerA + ((CornerB -CornerA) / 2.0f);
            selectionBox.size = new Vector3(Mathf.Abs(CornerB.x - CornerA.x), CollisionBoxHeight, Mathf.Abs(CornerB.z - CornerA.z));
            selectionBox.enabled = true;

        } else
        {
            selectionBox.enabled = false;
        }
    }

    public HashSet<UnitController> GetSelectedUnits()
    {
        return Units;
    }

    private void clickAction()
    {
      
        p1 = controls.UI.CursorPosition.ReadValue<Vector2>();
        selectUnit();
    }

    private void holdAction()
    {

        tryToClearAndDeselect();
        dragAction = true; 
    }

    private void releaseAction()
    {
        dragAction = false;
    }

    /**
     * Selects a single unit using a raycast from the mouse position.
     * -if no unit is found all previously selected units are deselected.
     * -if a new unit is found all previously selected units are deselected.
     */
    private void selectUnit()
    {
        tryToClearAndDeselect();
        if (Physics.Raycast(Camera.main.ScreenPointToRay(controls.UI.CursorPosition.ReadValue<Vector2>()), out RaycastHit hit, raydistance, -1, QueryTriggerInteraction.Ignore) 
            && hit.transform.gameObject.CompareTag("Selectable"))
        {           
                UnitController controller;
                if (controller = hit.transform.gameObject.GetComponent<UnitController>())
                {                    
                    controller.SelectUnit();
                    Units.Add(controller);
                }
        }       

    }

    private void tryToClearAndDeselect()
    {
        if (!multiSelect)
        {
            deselectUnits(Units);
            Units.Clear();
        }
    }



    private void deselectUnits(HashSet<UnitController> units)
    {
        if (units != null)
        {
            foreach (UnitController uc in units)
            {
                uc.DeselectUnit();
            }
        }
    }

    private Vector3 getPositionInWorld(Vector2 screenPosition)
    {
        Physics.Raycast(Camera.main.ScreenPointToRay(screenPosition), out RaycastHit hit, raydistance, BoxSelectLayerMask);
        return hit.point;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Selectable"))
        {
            UnitController controller;
            if (controller = other.transform.gameObject.GetComponent<UnitController>())
            {
                controller.SelectUnit();
                Units.Add(controller);
            }
        }
    }

    /**
     * draws the GUI approximation of the selection box.
     */
    private void OnGUI()
    {
        if (dragAction)
        {
            GUI.DrawTexture(Utils.GetScreenRect(p1, controls.UI.CursorPosition.ReadValue<Vector2>()), UIBoxTexture);   
        }         
    }


    void print(string message)
    {
        Debug.Log(message);
    }
}
