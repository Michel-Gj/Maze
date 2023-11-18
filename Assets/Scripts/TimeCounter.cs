using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    float timer = 0;
    public Text timeOut;
    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        timeOut.text = "Time: " + timer;
    }
}
