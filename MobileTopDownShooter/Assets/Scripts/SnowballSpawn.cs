using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballSpawn : MonoBehaviour
{
    public GameObject[] wayPoint;
    public GameObject snowBall;
    public int num;
    public float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > 3)
        {
            Spawner();
            spawnTimer = 0;
        }
        
    }
    public void Spawner()
    {
       num = Random.Range(0,3);

       
        Instantiate(snowBall, wayPoint[num].transform.position, Quaternion.identity);
    }
   
}
