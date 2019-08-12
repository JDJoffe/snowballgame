using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManManager : MonoBehaviour
{
    // public GameObject snowman;
    public GameObject[] targets = new GameObject[3];
    public GameObject[] snowMen = new GameObject[3];
    public GameObject[] detectors = new GameObject[3];

    public float speed = 1f;
    public bool[] snowmanAlive = new bool[3];
    // Start is called before the first frame update
    void Awake()
    {
        //auto grab stuff in heirarchy

        targets[0] = GameObject.Find("Target1");
        targets[1] = GameObject.Find("Target2");
        targets[2] = GameObject.Find("Target3");

        snowMen[0] = GameObject.Find("Snowman1");
        snowMen[1] = GameObject.Find("Snowman2");
        snowMen[2] = GameObject.Find("Snowman3");

       // detectors[]
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

    }

    void Movement()
    {
        //move all snowmen to waypoints
        for (int i = 0; i < 3; i++)
        {
            float move = speed * Time.deltaTime;
            snowMen[i].transform.position = Vector3.MoveTowards(snowMen[i].transform.position, targets[i].transform.position, move);
        }      
       

    }

    //detect snowmen in the lanes (not working yet)
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("SnowMan1")) { snowmanAlive[0] = true; }
        if (other.tag == "SnowMan2") { snowmanAlive[1] = true; }
      //  if (other.gameObject.tag == "SnowMan3") { snowmanAlive[2] = true; }



    }
}
