using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(NavMeshAgent))]
public class UnitController : MonoBehaviour
{
    
    public bool isSelected = false;
    public Material SelectionMaterial;

    Material defaultMaterial;
    MeshRenderer mr;

    NavMeshAgent agent;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        defaultMaterial = mr.sharedMaterial;
        agent = GetComponent<NavMeshAgent>();
        agent.avoidancePriority = Random.Range(0, 99);
    }

    public void SelectUnit()
    {
        isSelected = true;
        mr.material = SelectionMaterial;
    }

    public void DeselectUnit()
    {
        isSelected = false;
        mr.material = defaultMaterial;
    }

    public void SetPriority (int p)
    {
        agent.avoidancePriority = p;
    }

    public void OrderUnitToPosition(Vector3 Target)
    {
        agent.SetDestination(Target);
    }
}
