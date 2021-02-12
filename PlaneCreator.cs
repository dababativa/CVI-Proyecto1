using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCreator : MonoBehaviour
{

    GameObject bigPlane;
    GameObject road;
    GameObject road2;
    GameObject roadSteps;
    Color CanvasColor = Color.green;
    Color RoadColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        createCanvas();
        createRoad();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void createCanvas()
    {
        bigPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        bigPlane.transform.localScale = new Vector3(5, 5, 5);
        bigPlane.transform.position = new Vector3(0, 0, 0);
        bigPlane.GetComponent<Renderer>().material.color = CanvasColor;
    }

    void createRoad()
    {
        road = GameObject.CreatePrimitive(PrimitiveType.Plane);
        road.transform.localScale = new Vector3(1, 1, 5);
        road.GetComponent<Renderer>().material.color = RoadColor;
        road.transform.position = new Vector3(-10, 0.1f, 0);
        road2 = GameObject.CreatePrimitive(PrimitiveType.Plane);
        road2.transform.localScale = new Vector3(1, 1, 5);
        road2.GetComponent<Renderer>().material.color = RoadColor;
        road2.transform.position = new Vector3(10, 0.1f, 0);
    }
}
