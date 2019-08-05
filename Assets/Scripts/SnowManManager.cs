using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManManager : MonoBehaviour
{
    public GameObject[] snowMen;
    public GameObject[] detectors;
    public int curSnowMan;
    public int snowmanMax = 3;
    public int snowmanNum;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (curSnowMan = 0; curSnowMan < 3; curSnowMan++)
        {
            if (snowMen[curSnowMan].gameObject.activeInHierarchy)
            {
                Movement();
            }
        }
       
    }

    void Movement()
    {
        Vector3 num = new Vector3(0, 0, -1);
        snowMen[curSnowMan].transform.position = num;
    }

    private void OnTriggerStay(Collider other)
    {
        other.CompareTag("SnowMan1");
        other.CompareTag("SnowMan2");
        other.CompareTag("SnowMan3");
    }
}
