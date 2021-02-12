using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunelSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createWholeStructure(new Vector3(-0.12f, 0, 35.9f));
        createWholeStructure(new Vector3(-0.12f, 0, -35.9f));
        //createTunel(new Vector3(-0.12f, 0, -35.9f));

        //entrances(new Vector3(-10f, 1.97f, 25.3f), new Vector3(10f, 1.97f, 25.3f));
        //entrances(new Vector3(-10f, 1.97f, -25.3f), new Vector3(10f, 1.97f, -25.3f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    void createWholeStructure(Vector3 position)
    {
        GameObject bigTunel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigTunel.transform.localScale = new Vector3(40, 10, 22);
        bigTunel.transform.position = position;
        bigTunel.transform.GetComponent<Renderer>().material.color = Color.gray;
        GameObject leftEntrance = GameObject.CreatePrimitive(PrimitiveType.Cube);
        leftEntrance.transform.parent = bigTunel.transform;
        leftEntrance.transform.localScale = new Vector3(0.27f, 0.4f, 1.01f);
        leftEntrance.transform.localPosition = new Vector3(-0.246f, 0.2f, 0f);
        leftEntrance.transform.GetComponent<Renderer>().material.color = Color.black;

        GameObject rightEntrance = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rightEntrance.transform.parent = bigTunel.transform;
        rightEntrance.transform.localScale = new Vector3(0.27f, 0.4f, 1.01f);
        rightEntrance.transform.localPosition = new Vector3(0.255f, 0.2f, 0f);
        rightEntrance.transform.GetComponent<Renderer>().material.color = Color.black;
    }


   


}
