using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    [Header("Head Anim Position")]
    public Vector3 Pos1;
    public Vector3 Pos2;
    public float AnimSpeed;
    void FixedUpdate()
    {
        gameObject.GetComponent<Transform>().localPosition = Vector3.Lerp(Pos1, Pos2, Mathf.PingPong(Time.time * AnimSpeed,1.0f));
    }
}//class
