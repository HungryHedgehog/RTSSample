using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CommandUnits : MonoBehaviour
{
    public InputManager _InputManager;
    public SelectUnits _SelectUnits;
    public LayerMask RaycastLayerMask;

    PlayerControls controls;
    readonly float raydistance = 1000.0f;
    //how far away from a source point can a valid navmesh point be selected
    readonly float navMeshValidPointRadius = 5.0f;
    private void Start()
    {
        controls = _InputManager.GetControls();

        controls.UI.MoveToAction.performed += ctx => MoveToOrder();
    }

    public void MoveToOrder()
    {
        
        IEnumerator<UnitController> unitEnumerator = _SelectUnits.GetSelectedUnits().GetEnumerator();        
        if (unitEnumerator.MoveNext() && Physics.Raycast(Camera.main.ScreenPointToRay(controls.UI.CursorPosition.ReadValue<Vector2>()), out RaycastHit hit, raydistance, RaycastLayerMask))
        {
            
            do
            {
                if (NavMesh.SamplePosition(hit.point + Random.insideUnitSphere * unitEnumerator.Current.GetAgentRadius(), out NavMeshHit navhit, navMeshValidPointRadius, -1))
                {
                    unitEnumerator.Current.OrderUnitToPosition(navhit.position);                   
                }
                unitEnumerator.MoveNext();
            } while(unitEnumerator.Current);


        }

    }

}
