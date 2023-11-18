using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCube : MonoBehaviour
{
    [SerializeField]
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(GameObject.Find("FPSController").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
