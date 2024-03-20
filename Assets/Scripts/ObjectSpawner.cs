using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnObjects;

    [Header("Spawning Settings")]

    [SerializeField] private int spawnCount;
    [SerializeField] private Vector3 spawnArea;
    [SerializeField] private bool continousSpawning;
    [SerializeField] private float spawningInterval;

    [Header("Object Settings")]

    [SerializeField] private float minSize = 1f;
    [SerializeField] private float maxSize = 1f;

    [SerializeField] private bool randomSize = false;
    [SerializeField] private bool spawnRandom;


    //private variables
    private float timer = 0f;
    private int index = 0;
    private Vector3 spawnSize;
    private float size;

    void Start()
    {
        timer = spawningInterval;

        index = 0;

        spawnSize = new Vector3(maxSize, maxSize, maxSize);


        if (!continousSpawning && spawnObjects != null)
        {
            index = 0;
            for (int i = 0; i <= spawnCount; i++)
            {
                if (!spawnRandom)
                {

                    Vector3 pos = transform.position + new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), Random.Range(-spawnArea.y / 2, spawnArea.y / 2), Random.Range(-spawnArea.z / 2, spawnArea.z / 2));

                    GameObject newObject = Instantiate(spawnObjects[index], pos, transform.rotation);

                    if (randomSize)
                    {
                        size = Random.Range(minSize, maxSize);
                        spawnSize = new Vector3(size, size, size);
                    }

                    newObject.transform.localScale = spawnSize;
                    index++;
                    if (index >=  spawnObjects.Length)
                    {
                        index = 0;
                    }
                }
                else
                {

                    Vector3 pos = transform.position + new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), Random.Range(-spawnArea.y / 2, spawnArea.y / 2), Random.Range(-spawnArea.z / 2, spawnArea.z / 2));

                    GameObject newObject = Instantiate(spawnObjects[index], pos, transform.rotation);

                    if (randomSize)
                    {
                        size = Random.Range(minSize, maxSize);
                        spawnSize = new Vector3(size, size, size);
                    }

                    newObject.transform.localScale = spawnSize;
                    index = Random.Range(0, spawnObjects.Length);
                }
            }
        }


    }

    void FixedUpdate()
    {
        if (continousSpawning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                if (!spawnRandom)
                {

                    Vector3 pos = transform.position + new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), Random.Range(-spawnArea.y / 2, spawnArea.y / 2), Random.Range(-spawnArea.z / 2, spawnArea.z / 2));

                    GameObject newObject = Instantiate(spawnObjects[index], pos, transform.rotation);

                    if (randomSize)
                    {
                        size = Random.Range(minSize, maxSize);
                        spawnSize = new Vector3(size, size, size);
                    }

                    newObject.transform.localScale = spawnSize;
                    index++;

                    if (index == spawnObjects.Length)
                    {
                        index = 0;
                    }
                }
                else
                {
                    index = Random.Range(0, spawnObjects.Length);


                    Vector3 pos = transform.position + new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), Random.Range(-spawnArea.y / 2, spawnArea.y / 2), Random.Range(-spawnArea.z / 2, spawnArea.z / 2));

                    GameObject newObject = Instantiate(spawnObjects[index], pos, transform.rotation);

                    if (randomSize)
                    {
                        size = Random.Range(minSize, maxSize);
                        spawnSize = new Vector3(size, size, size);
                    }

                    newObject.transform.localScale = spawnSize;
                }

                timer = spawningInterval;
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawWireCube(transform.position, spawnArea);
    }
}
