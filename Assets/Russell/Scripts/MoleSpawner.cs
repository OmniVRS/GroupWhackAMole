using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public GameObject molePrefab;
    private float spawnRate;
    private bool isPlaying = true;
    //X range is -2.31 to 2.32, Y range is -4.31 to 4.38
    // Start is called before the first fame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnEnemies()
    {
        while (isPlaying)
        {
            Instantiate(molePrefab, new Vector2(Random.Range(-2.31f, 2.32f), Random.Range(-4.31f, 4.38f)), molePrefab.transform.rotation);
            yield return new WaitForSeconds(3);
            //yield return new WaitForEndOfFrame();
        }
       
    }
}
