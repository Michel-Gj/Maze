using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRot : MonoBehaviour
{
    public float rotationSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,rotationSpeed , 0) * Time.deltaTime);
    }
}
