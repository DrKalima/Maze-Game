using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float m_Speed;
    [SerializeField] private float spinSpeed = 5f;
    bool m_WorldSpace;

    void Update()
    {
        //Set the speed of the rotation
        m_Speed = 20.0f;
        //Start off in World.Space
        m_WorldSpace = true;
        //Rotate the GameObject a little at the start to show the difference between Space and Local
        transform.Rotate(0, spinSpeed, 0);
    }

}
