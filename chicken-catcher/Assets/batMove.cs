using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batMove : MonoBehaviour
{
    // Start is called before the first frame update
    //private int orientation = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyspeed = 0.9f;
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.Rotate(0f,0f,45f);
            //transform.position = transform.position + new Vector3(0, -1, 0) * keyspeed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.position = transform.position + new Vector3(0, 1, 0) * keyspeed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.position = transform.position + new Vector3(0, -1, 0) * keyspeed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.position = transform.position + new Vector3(1, 0, 0) * keyspeed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.position = transform.position + new Vector3(-1, 0, 0) * keyspeed;
        }
    }
}
