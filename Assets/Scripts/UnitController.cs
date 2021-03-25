using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(NavMeshObstacle))]
public class UnitController : MonoBehaviour
{
    
   
    public Material SelectionMaterial;

    Material defaultMaterial;
    MeshRenderer mr;

    NavMeshAgent agent;
    NavMeshObstacle obstacle;

    bool isSelected = false;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        defaultMaterial = mr.sharedMaterial;

        agent = GetComponent<NavMeshAgent>();
        agent.avoidancePriority = Random.Range(0, 99);

        obstacle = GetComponent<NavMeshObstacle>();
        obstacle.enabled = false;
    }
    private void Update()
    {
        //if the agent has completed it's movement order turn into obstacle for better local area avoidance of others
        if(agent && agent.pathStatus.Equals(NavMeshPathStatus.PathComplete) && agent.remainingDistance == 0)
        {
            agent.enabled = false;
            obstacle.enabled = true;
        }
    }

    public bool CheckIfSelected()
    {
        return isSelected;
    }

    public float GetAgentRadius()
    {
        return agent.radius;
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

    /**
     * Enables agent and gives them a destination.
     * Disables obstacle.
     */
    public void OrderUnitToPosition(Vector3 Target)
    {
        obstacle.enabled = false;
        agent.enabled = true;        
        agent.SetDestination(Target);
    }
}
