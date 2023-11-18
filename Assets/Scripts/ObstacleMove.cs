using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float moveX=1f;
    public float moveY = 1f;
    public float moveZ = 1f;
    public float maxDistance = 5f;
    private Vector3 startPosition;
    private bool changeDir = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveX, moveY, moveZ) * Time.deltaTime);
        if (Vector3.Distance(startPosition,transform.position)>maxDistance&&changeDir)
        {
            moveX *= -1;
            moveY *= -1;
            moveZ *= -1;
            changeDir = false;
        }
        else if (Vector3.Distance(startPosition, transform.position) <1&& !changeDir)
        {
            changeDir = true;
        }
    }
}
