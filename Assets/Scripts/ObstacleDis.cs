using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDis : MonoBehaviour
{
    public float CONST_SWITCHTIME = 5f;
    private float switchTime = 5f;
    private Collider collider;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        switchTime = CONST_SWITCHTIME;
        collider = GetComponent<Collider>();
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switchTime = switchTime-1f * Time.deltaTime;
        if (switchTime<0)
        {
            collider.enabled = !collider.enabled;
            renderer.enabled = !renderer.enabled;
            switchTime = CONST_SWITCHTIME;
        }
    }
}
