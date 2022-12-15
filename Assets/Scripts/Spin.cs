using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform target;
    public float orbitdistance;
    public float speed;
    public float orbitspeed;
    public float fallspeed;

    void Start()
    {
        target = GameObject.Find("earth").transform;
    }

    void FixedUpdate() //runs at refresh rate
    {
        orbitdistance -= fallspeed * Time.deltaTime;
        speed = Mathf.Pow((orbitspeed / orbitdistance), 4); //calculate speed from speed and distance

        transform.position = target.position + (transform.position - target.position).normalized * orbitdistance; //set position
        transform.RotateAround(target.position, Vector3.forward, speed * Time.deltaTime); //rotate at orbit speed
    }
}
