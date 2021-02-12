using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTransmilenio : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RotateAmount;
    GameObject transmi1;
    GameObject transmi2;
    GameObject transmi3;
    GameObject transmi4;
    void Start()
    {
        transmi1 = createWholeVehicle(new Vector3(-12, 0.68f, -30.24f));
        transmi2 = createWholeVehicle(new Vector3(-8, 0.68f, -30.55f));
        transmi3 = createWholeVehicle(new Vector3(8, 0.68f, 26.498f));
        transmi4 = createWholeVehicle(new Vector3(12, 0.68f, 26.498f));
    }

    // Update is called once per frame
    void Update()
    {
        transmi1.transform.Translate(Vector3.forward * Time.deltaTime * 8);
        float z = transmi1.transform.position.z;
        double limitZ = 26.467;
        if (z >= limitZ)
        {
            transmi1.transform.position = (new Vector3(-12, 0.68f, -30.24f));
        }

        transmi2.transform.Translate(Vector3.forward * Time.deltaTime * 10);
        float z2 = transmi2.transform.position.z;
        if (z2 >= limitZ)
        {
            transmi2.transform.position = (new Vector3(-8, 0.68f, -30.55f));
        }

        transmi3.transform.Translate(Vector3.back * Time.deltaTime * 6);
        float z3 = transmi3.transform.position.z;
        double limitZ3 = -30.79;
        if (z3 <= limitZ3)
        {
            transmi3.transform.position = (new Vector3(8, 0.68f, 26.498f));
        }

        transmi4.transform.Translate(Vector3.back * Time.deltaTime * 7);
        float z4 = transmi4.transform.position.z;
        if (z4 <= limitZ3)
        {
            transmi4.transform.position = (new Vector3(12, 0.68f, 26.498f));
        }


    }

    GameObject createWholeVehicle(Vector3 position)
    {
        GameObject trunk = GameObject.CreatePrimitive(PrimitiveType.Cube);
        trunk.transform.localScale = new Vector3(1, 1, 3.054f);
        trunk.transform.position = position;
        trunk.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject trunk2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        trunk2.transform.parent = trunk.transform;
        trunk2.transform.localScale = new Vector3(1, 1, 1);
        trunk2.transform.localPosition = new Vector3(0, 0, 1.356f);
        trunk2.transform.GetComponent<Renderer>().material.color = Color.red;

        GameObject wheel = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        wheel.transform.parent = trunk.transform;
        wheel.transform.localScale = new Vector3(0.4114f, 0.56803f, 0.15f);
        wheel.transform.Rotate(0, 0, 90, Space.Self);
        wheel.transform.localPosition = new Vector3(0, -0.393f, -0.323f);
        wheel.transform.GetComponent<Renderer>().material.color = Color.black;
        GameObject wheel2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        wheel2.transform.parent = trunk.transform;
        wheel2.transform.localScale = new Vector3(0.4114f, 0.56803f, 0.15f);
        wheel2.transform.Rotate(0, 0, 90, Space.Self);
        wheel2.transform.localPosition = new Vector3(0, -0.393f, 0.323f);
        wheel2.transform.GetComponent<Renderer>().material.color = Color.black;


        GameObject wheel3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        wheel3.transform.parent = trunk2.transform;
        wheel3.transform.localScale = new Vector3(0.4114f, 0.56803f, 0.15f);
        wheel3.transform.Rotate(0, 0, 90, Space.Self);
        wheel3.transform.localPosition = new Vector3(0, -0.393f, -0.323f);
        wheel3.transform.GetComponent<Renderer>().material.color = Color.black;
        GameObject wheel4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        wheel4.transform.parent = trunk2.transform;
        wheel4.transform.localScale = new Vector3(0.4114f, 0.56803f, 0.15f);
        wheel4.transform.Rotate(0, 0, 90, Space.Self);
        wheel4.transform.localPosition = new Vector3(0, -0.393f, 0.323f);
        wheel4.transform.GetComponent<Renderer>().material.color = Color.black;

        GameObject smallIntersection = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection.transform.parent = trunk.transform;
        smallIntersection.transform.localScale = new Vector3(0.90806f, 0.87f, 0.02f);
        smallIntersection.transform.localPosition = new Vector3(0,0, 0.508f);
        smallIntersection.transform.GetComponent<Renderer>().material.color = Color.gray;


        GameObject bigIntersection = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection.transform.parent = smallIntersection.transform;
        bigIntersection.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection2.transform.parent = smallIntersection.transform;
        smallIntersection2.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection2.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection2.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection2.transform.parent = smallIntersection2.transform;
        bigIntersection2.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection2.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection2.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection3.transform.parent = smallIntersection2.transform;
        smallIntersection3.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection3.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection3.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection3.transform.parent = smallIntersection3.transform;
        bigIntersection3.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection3.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection3.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection4.transform.parent = smallIntersection3.transform;
        smallIntersection4.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection4.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection4.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection4.transform.parent = smallIntersection4.transform;
        bigIntersection4.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection4.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection4.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection5.transform.parent = smallIntersection4.transform;
        smallIntersection5.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection5.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection5.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection5.transform.parent = smallIntersection5.transform;
        bigIntersection5.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection5.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection5.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection6.transform.parent = smallIntersection5.transform;
        smallIntersection6.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection6.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection6.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection6.transform.parent = smallIntersection6.transform;
        bigIntersection6.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection6.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection6.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection7.transform.parent = smallIntersection6.transform;
        smallIntersection7.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection7.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection7.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection7.transform.parent = smallIntersection7.transform;
        bigIntersection7.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection7.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection7.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection8.transform.parent = smallIntersection7.transform;
        smallIntersection8.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection8.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection8.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection8.transform.parent = smallIntersection8.transform;
        bigIntersection8.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection8.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection8.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection9.transform.parent = smallIntersection8.transform;
        smallIntersection9.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection9.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection9.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection9.transform.parent = smallIntersection9.transform;
        bigIntersection9.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection9.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection9.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject smallIntersection10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        smallIntersection10.transform.parent = smallIntersection9.transform;
        smallIntersection10.transform.localScale = new Vector3(1f, 1f, 1f);
        smallIntersection10.transform.localPosition = new Vector3(0, 0, 1.8f);
        smallIntersection10.transform.GetComponent<Renderer>().material.color = Color.gray;

        GameObject bigIntersection10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bigIntersection10.transform.parent = smallIntersection10.transform;
        bigIntersection10.transform.localScale = new Vector3(0.838272f, 0.9f, 1.2f);
        bigIntersection10.transform.localPosition = new Vector3(0f, 0f, 0.88f);
        bigIntersection10.transform.GetComponent<Renderer>().material.color = Color.gray;
        return trunk;


    }

    void Erase(GameObject transmilenio)
    {
        Destroy(transmilenio);
    }

    
}
