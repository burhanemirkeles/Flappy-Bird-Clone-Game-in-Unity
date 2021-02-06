using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird bird;
    public GameObject Pipes;
    public float height;
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!bird.isDead)
        { 
            Instantiate(Pipes, new Vector3(12, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
        
    }
}
