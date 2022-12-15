using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinEarth : MonoBehaviour
{

    public float spinRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, spinRate * Time.deltaTime);
    }
}
