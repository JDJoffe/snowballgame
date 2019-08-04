using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManManager : MonoBehaviour
{
    public GameObject[] snowMen;
    public int curSnowMan;
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
}
