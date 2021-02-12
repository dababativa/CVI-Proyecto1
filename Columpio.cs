using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columpio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createColumpio(new Vector3(0.15f, 1.38f, 5.24f));
        createColumpio(new Vector3(0.15f, 1.38f, 15.2166f));
        createColumpio(new Vector3(0.15f, 1.38f, -4.597f));
        createColumpio(new Vector3(0.15f, 1.38f, -14.9533f));
        //createColumpio2();
        //createColumpio3();
        //createColumpio4();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createColumpio(Vector3 position)
    {

        GameObject topBar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        topBar.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        topBar.transform.Rotate(90, 0, 0, Space.Self);
        topBar.transform.position = position;
        topBar.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar1.transform.parent = topBar.transform;
        leftBar1.transform.localScale = new Vector3(1f, 10.22f, 0.1f);
        leftBar1.transform.Rotate(0,0,-45f, Space.Self);
        leftBar1.transform.localPosition = new Vector3(-7.45f, 0.9f, 7.32f);
        leftBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar2.transform.parent = topBar.transform;
        leftBar2.transform.localScale = new Vector3(1f, 10.22f, 0.1f);
        leftBar2.transform.Rotate(0, 0, 45f, Space.Self);
        leftBar2.transform.localPosition = new Vector3(7.45f, 0.9f, 7.32f);
        leftBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar1.transform.parent = topBar.transform;
        rightBar1.transform.localScale = new Vector3(1f, 10.22f, 0.1f);
        rightBar1.transform.Rotate(0, 0, -45f, Space.Self);
        rightBar1.transform.localPosition = new Vector3(-7.45f, -0.9f, 7.32f);
        rightBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar2.transform.parent = topBar.transform;
        rightBar2.transform.localScale = new Vector3(1f, 10.22f, 0.1f);
        rightBar2.transform.Rotate(0, 0, 45f, Space.Self);
        rightBar2.transform.localPosition = new Vector3(7.45f, -0.9f, 7.32f);
        rightBar2.transform.GetComponent<Renderer>().material.color = Color.red;


        GameObject leftHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftHanger.transform.parent = topBar.transform;
        leftHanger.transform.localScale = new Vector3(0.01f, 4.1f, 0.01f);
        leftHanger.transform.localPosition = new Vector3(0.15f, 0.411f, 4.06f);
        leftHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject rightHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightHanger.transform.parent = topBar.transform;
        rightHanger.transform.localScale = new Vector3(0.01f, 4.1f, 0.01f);
        rightHanger.transform.localPosition = new Vector3(0.15f, -0.411f, 4.06f);
        rightHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject seat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seat.transform.parent = topBar.transform;
        seat.transform.localScale = new Vector3(3f, 0.01f, 1);
        seat.transform.localPosition = new Vector3(0f, 0, 8.17f);
        seat.transform.GetComponent<Renderer>().material.color = Color.black;
        
    }


    void createColumpio2()
    {
        GameObject leftBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar1.transform.Rotate(0, 0, -45f, Space.Self);
        leftBar1.transform.position = new Vector3(-0.57f, 0.633f, 16.13f);
        leftBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar2.transform.Rotate(0, 0, 45f, Space.Self);
        leftBar2.transform.position = new Vector3(0.895f, 0.633f, 16.13f);
        leftBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar1.transform.Rotate(0, 0, -45f, Space.Self);
        rightBar1.transform.position = new Vector3(-0.57f, 0.633f, 14.27668f);
        rightBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar2.transform.Rotate(0, 0, 45f, Space.Self);
        rightBar2.transform.position = new Vector3(0.895f, 0.633f, 14.27668f);
        rightBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject topBar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        topBar.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        topBar.transform.Rotate(90, 0, 0, Space.Self);
        topBar.transform.position = new Vector3(0.15f, 1.38f, 15.2166f);
        topBar.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        leftHanger.transform.position = new Vector3(0.15f, 0.969f, 15.6556f);
        leftHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject rightHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        rightHanger.transform.position = new Vector3(0.15f, 0.969f, 14.73868f);
        rightHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject seat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seat.transform.localScale = new Vector3(0.3f, 0.01f, 1);
        seat.transform.position = new Vector3(0.16f, 0.556f, 15.1936f);
        seat.transform.GetComponent<Renderer>().material.color = Color.black;
    }

    void createColumpio3()
    {
        GameObject leftBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar1.transform.Rotate(0, 0, -45f, Space.Self);
        leftBar1.transform.position = new Vector3(-0.57f, 0.633f, -3.68368f);
        leftBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar2.transform.Rotate(0, 0, 45f, Space.Self);
        leftBar2.transform.position = new Vector3(0.895f, 0.633f, -3.68368f);
        leftBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar1.transform.Rotate(0, 0, -45f, Space.Self);
        rightBar1.transform.position = new Vector3(-0.57f, 0.633f, -5.537f);
        rightBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar2.transform.Rotate(0, 0, 45f, Space.Self);
        rightBar2.transform.position = new Vector3(0.895f, 0.633f, -5.537f);
        rightBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject topBar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        topBar.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        topBar.transform.Rotate(90, 0, 0, Space.Self);
        topBar.transform.position = new Vector3(0.15f, 1.38f, -4.597f);
        topBar.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        leftHanger.transform.position = new Vector3(0.15f, 0.969f, -4.158f);
        leftHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject rightHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        rightHanger.transform.position = new Vector3(0.15f, 0.969f, -5.075f);
        rightHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject seat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seat.transform.localScale = new Vector3(0.3f, 0.01f, 1);
        seat.transform.position = new Vector3(0.16f, 0.556f, -4.62f);
        seat.transform.GetComponent<Renderer>().material.color = Color.black;
    }

    void createColumpio4()
    {
        GameObject leftBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar1.transform.Rotate(0, 0, -45f, Space.Self);
        leftBar1.transform.position = new Vector3(-0.57f, 0.633f, -14.04f);
        leftBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        leftBar2.transform.Rotate(0, 0, 45f, Space.Self);
        leftBar2.transform.position = new Vector3(0.895f, 0.633f, -14.04f);
        leftBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar1.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar1.transform.Rotate(0, 0, -45f, Space.Self);
        rightBar1.transform.position = new Vector3(-0.57f, 0.633f, -15.8933f);
        rightBar1.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject rightBar2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightBar2.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        rightBar2.transform.Rotate(0, 0, 45f, Space.Self);
        rightBar2.transform.position = new Vector3(0.895f, 0.633f, -15.8933f);
        rightBar2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject topBar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        topBar.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        topBar.transform.Rotate(90, 0, 0, Space.Self);
        topBar.transform.position = new Vector3(0.15f, 1.38f, -14.9533f);
        topBar.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject leftHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        leftHanger.transform.position = new Vector3(0.15f, 0.969f, -14.5143f);
        leftHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject rightHanger = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightHanger.transform.localScale = new Vector3(0.01f, 0.4f, 0.01f);
        rightHanger.transform.position = new Vector3(0.15f, 0.969f, -15.4313f);
        rightHanger.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject seat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seat.transform.localScale = new Vector3(0.3f, 0.01f, 1);
        seat.transform.position = new Vector3(0.16f, 0.556f, -14.9763f);
        seat.transform.GetComponent<Renderer>().material.color = Color.black;
    }



}
