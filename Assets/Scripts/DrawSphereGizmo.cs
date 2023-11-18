using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSphereGizmo : MonoBehaviour
{
    public float sphereRadius = 3f;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0.2f, 1f, 0.75f);
        Gizmos.DrawSphere(transform.position, sphereRadius);
    }
}
