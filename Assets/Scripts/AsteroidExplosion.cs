using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidExplosion : MonoBehaviour
{
    public GameObject explosionFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            GameObject asteroid = other.gameObject; //set asteroid to object that collided
            Destroy(asteroid); //destroy asteroid
            Quaternion rotation = Quaternion.LookRotation(asteroid.transform.position - transform.position, Vector3.left);
            var heading = asteroid.transform.position - this.transform.position;
            var distance = heading.magnitude;
            var direction = heading / distance; // This is now the normalized direction.

            Instantiate(explosionFX, asteroid.transform.position, direction); //create particle simulation at asteroids position
            Debug.DrawRay(transform.position, asteroid.transform.position, Color.red, 5f);
        }
    }
}
