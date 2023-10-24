using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnRate = 3.0F;
    private float timer = 0.0F;
    public float startOffset = 15.5F;
    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteroid();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnAsteroid();
        }
    }

    void SpawnAsteroid()
    {
        float leftmostPoint = transform.position.x - startOffset;
        float rightmostPoint = transform.position.x + startOffset;
        Instantiate(asteroid, new Vector3(Random.Range(leftmostPoint, rightmostPoint), transform.position.y, 0), transform.rotation);
        timer = 0.0F;
    }
}
