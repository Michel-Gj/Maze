using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public AIPathfinding pathfinder;

    // Start is called before the first frame update
    void Start()
    {
        pathfinder = GetComponentInParent<AIPathfinding>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pathfinder.engageMode)
        {
            transform.LookAt(pathfinder.toAttack.transform.position);
        }
    }
}
