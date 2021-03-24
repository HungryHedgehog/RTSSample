using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CommandUnits : MonoBehaviour
{
    public InputManager _InputManager;
    public SelectUnits UnitSelectionScript;

    public LayerMask RaycastLayerMask;

    PlayerControls controls;
    float raydistance = 1000.0f;
    //how far away from a source point can a valid navmesh point be selected
    float navMeshValidPointRadius = 5.0f;
    private void Start()
    {
        controls = _InputManager.GetControls();

        controls.UI.MoveToAction.performed += ctx => MoveToOrder();
    }

    public void MoveToOrder()
    {
        RaycastHit hit;
        NavMeshHit nhit;
        Physics.Raycast(Camera.main.ScreenPointToRay(controls.UI.CursorPosition.ReadValue<Vector2>()), out hit, raydistance, RaycastLayerMask);

        if(NavMesh.SamplePosition(hit.point, out nhit, navMeshValidPointRadius, -1))
        {
            foreach(UnitController uc in UnitSelectionScript.GetSelectedUnits()) {
                uc.OrderUnitToPosition(nhit.position);
            }
        }

    }

}
