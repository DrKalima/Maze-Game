using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float movementSpeed = 10f;
        
    void Update()
    {
                           
            //update the position
            transform.position = transform.position + new Vector3(-1.0f * Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0f, -1.0f * Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
                                
    }
        
}
