using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public GameObject molePrefab;
    private GameManager gm;
    private float spawnRate;
    public bool isPlaying = false;
    public bool started;
    //X range is -2.31 to 2.32, Y range is -4.31 to 4.38
    // Start is called before the first fame update
    void Start()
    {
        //StartCoroutine(SpawnEnemies());
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnEnemies()
    {
        while (isPlaying)
        {
            Instantiate(molePrefab, new Vector2(Random.Range(-2.31f, 2.32f), Random.Range(-4.31f, 4.38f)), molePrefab.transform.rotation);
            gm.audioSource.PlayOneShot(gm.spawnSound);
            yield return new WaitForSeconds(3);
            //yield return new WaitForEndOfFrame();
        }
       
    }

    public void RemoteSpawn()
    {
        StartCoroutine(SpawnEnemies());
    }
}
