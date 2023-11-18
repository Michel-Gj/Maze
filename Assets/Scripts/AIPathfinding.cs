using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPathfinding : MonoBehaviour
{
    NavMeshAgent agent;
    public bool findWayOnce = false;
    public bool findWholePath = false;
    public Vector3 wayPointForOnce;
    public GameObject[] pathPoints;
    public int currentDestination = 0;
    public GameObject toAttack;
    public float attackLimiterMin = 10f;
    public float attackLimiterMax = 12f;
    public bool engageMode = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (findWayOnce)
        {
            agent.SetDestination(wayPointForOnce);
            findWholePath = false;
        }
        else if (findWholePath)
        {
            agent.SetDestination(pathPoints[currentDestination].transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (findWholePath&&!engageMode)
        {
            FindPath();
        }
        if (!engageMode&&toAttack != null&&Vector3.Distance(transform.position,toAttack.transform.position)<attackLimiterMin)
        {
            findWholePath = false;
            engageMode = true;
        }
        else if(engageMode&& Vector3.Distance(transform.position, toAttack.transform.position) > attackLimiterMax+5){
            findWholePath = true;
            engageMode = false;
        }
        if (engageMode)
        {
            Engage();
        }
    }

    private void Engage()
    {
        if(Vector3.Distance(transform.position, toAttack.transform.position) > attackLimiterMin&& Vector3.Distance(transform.position, toAttack.transform.position) < attackLimiterMax)
        {
            agent.SetDestination(toAttack.transform.position);
        }
    }

    private void FindPath()
    {
        if (Vector3.Distance(transform.position,agent.destination)<2f)
        {
            currentDestination++;
            if (currentDestination>=pathPoints.Length)
            {
                currentDestination = 0;
            }
            agent.SetDestination(pathPoints[currentDestination].transform.position);
        }
    }
}
