using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float speed = 5.0f; 
    float dir = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode. UpArrow)) 
        { 
            Vector3 direction = new Vector3(); 
            direction = transform.forward * (speed * Time.deltaTime); 
            transform.Translate(direction, Space.World);
        }
        if (Input.GetKey (KeyCode. DownArrow)) 
        { 
            Vector3 direction = new Vector3(); 
            direction = transform.forward * (speed * Time.deltaTime); 
            transform.Translate(-direction, Space.World);
        }
        if (Input.GetKey (KeyCode.RightArrow)) 
        {
            dir = 10 * Time.deltaTime;
            transform.Rotate(0f, dir * 10, 0f, Space.Self);
        }
        if (Input.GetKey (KeyCode.LeftArrow)) 
        {
            dir = -10 * Time.deltaTime;
            transform.Rotate(0f, dir * 10, 0f, Space.Self);
        }
    }
}
