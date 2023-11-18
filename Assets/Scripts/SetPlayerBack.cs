using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerBack : MonoBehaviour
{
    Vector3 startPosition;
    public float minHeight = 5f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<minHeight)
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = startPosition;
            GetComponent<CharacterController>().enabled = true;
        }
    }
}
