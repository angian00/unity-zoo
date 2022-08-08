using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooManager : MonoBehaviour
{
	[SerializeField]
	private float SpawnInterval = 5; //in seconds

	[SerializeField]
	private GameObject[] AnimalPrefabs;

	private const float AnimalY = 1.0f;
	private const float spawnRangeX = 10.0f;
	private const float spawnRangeZ = 10.0f;


    void Start()
    {
        SpawnAnimal();
    }

    void Update()
    {
        
    }


    void SpawnAnimal()
	{
		int iAnimal = Random.Range(0, AnimalPrefabs.Length);

		float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
		float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
		Vector3 startPos = new Vector3(spawnPosX, AnimalY, spawnPosZ);
		Quaternion startRot = Random.rotation;

	    Instantiate(AnimalPrefabs[iAnimal], startPos, startRot);

		Invoke("SpawnAnimal", SpawnInterval);
	}

}
