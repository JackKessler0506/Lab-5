using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class SpawnManager : MonoBehaviour {

private float startDelay = 2; 
private float spawnInterval = 1.5f; 
private float spawnRangeX = 1; 
private float spawnPosZ = 1; 


public GameObject[] animalPrefabs; 


void Start() {
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
     } 
 // Start is called before the first frame update 
// Update is called once per frame 

void Update() {} 
// Ramdomly generate animal index and spawn position
     void SpawnRandomAnimal() {
           Vector3 spawnPos = new Vector3(-5, 0, Random.Range(1, 6)); 
    int animalIndex = Random.Range(0, animalPrefabs.Length); Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    }
} 