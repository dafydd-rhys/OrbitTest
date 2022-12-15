using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private Vector3 target;
    public float orbitdistance;
    public float speed;
    public float orbitspeed;
    public float fallspeed;
    public Sprite[] sprites;

    void Start()
    {
        target = Vector3.zero;
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, 3)];
        float scale = Random.Range(0.4f, 0.8f);
        gameObject.transform.localScale = new Vector3(scale, scale, 1);
    }

    void FixedUpdate() //runs at refresh rate
    {
        orbitdistance -= fallspeed * orbitdistance * Time.deltaTime;
        fallspeed = Mathf.Pow((orbitspeed / orbitdistance), 2); //calculate speed from speed and distance

        transform.position = target + (transform.position - target).normalized * orbitdistance; //set position
        transform.Rotate(new Vector3(0, 0, 20));
    }
}
