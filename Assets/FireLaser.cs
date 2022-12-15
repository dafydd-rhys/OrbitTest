using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public LineRenderer laserLine;
    public GameObject AsteroidSpawner;
    private AsteroidSpawner asteroidSpawn;
    // Start is called before the first frame update
    void Start()
    {
        asteroidSpawn = AsteroidSpawner.GetComponent<AsteroidSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 press = touch.position;
                press = Camera.main.ScreenToWorldPoint(press);
                laserLine.SetPosition(0, press);
                RaycastHit2D asteroids = Physics2D.Linecast(Vector2.zero, press, (1 << 9));
                if (asteroids.collider != null) //hit asteroid
                {
                    Destroy(asteroids.collider.gameObject);
                    int gems = PlayerPrefs.GetInt("GemCount");
                    PlayerPrefs.SetInt("GemCount", ++gems);
                    PlayerPrefs.Save();
                    asteroidSpawn.SpawnAsteroid();
                }
            }
        }
    }
}
