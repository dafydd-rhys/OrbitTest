using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject asteroid;
    public float innerRadius;
    public float outerRadius;


    public void SpawnAsteroid()
    {
        float ratio = innerRadius / outerRadius;
        float radius = Mathf.Sqrt(Random.Range(ratio * ratio, 1f)) * outerRadius;
        Vector3 point = Random.insideUnitCircle.normalized * radius; //calculate spawn position

        var obj = Instantiate(asteroid, new Vector3(point.x, point.y, 2.68f), Quaternion.identity); //instantiate asteroid
        obj.GetComponent<Spin>().orbitdistance = Vector2.Distance(Vector2.zero, new Vector2(point.x, point.y)); //set orbitdistance
        obj.GetComponent<Spin>().fallspeed = Random.Range(0.01f, 0.1f);
    }
}
