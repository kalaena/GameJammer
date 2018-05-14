using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float LeftEdgeOfMap;
    public float RightEdgeOfMap;
    public int MaxSimultaneousCars;
    public GameObject[] CarPrefabs = new GameObject[6];

    const float speed = 1.5f;

    private List<GameObject> spawnedCars = new List<GameObject>();

    private float spawnCooldown = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TrySpawnCar();
    }

    private void TrySpawnCar()
    {
        if (spawnCooldown <= 0.0f)
        {
            if (spawnedCars.Count < MaxSimultaneousCars)
            {
                SpawnCar();
            }

            spawnCooldown = Random.Range(1.0f, 5.0f);
        }
        else
        {
            spawnCooldown -= Time.deltaTime;
        }
    }

    public void SpawnCar()
    {
        //pick a random prefab
        int prefabIndex = Random.Range(0, CarPrefabs.Length);

        //pick random direction
        bool direction = Random.Range(0, 2) == 1; //0-->1 but using 2 because max is exclusive for some reason

        GameObject car = Instantiate(CarPrefabs[prefabIndex], new Vector3(direction ? -0.65f : -0.275f, 0.15f, direction ? RightEdgeOfMap : LeftEdgeOfMap), direction ? Quaternion.Euler(0.0f, 180.0f, 0.0f) : Quaternion.identity);
        Rigidbody rb = car.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f, 0.0f, direction ? -speed : speed);
        spawnedCars.Add(car);
    }

    public void OnCarDestroy(GameObject car)
    {
        spawnedCars.Remove(car);
    }
}
