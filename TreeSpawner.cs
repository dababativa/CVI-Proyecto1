using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    GameObject treeLocator;

    // Start is called before the first frame update
    void Start()
    {

        treeLocator = GameObject.CreatePrimitive(PrimitiveType.Plane);
        treeLocator.transform.GetComponent<Renderer>().material.color = Color.green;
        createTree(new Vector3(-23.71f, 1, -22.47f));
        createTree(new Vector3(-21.75f, 1, -23.02f));
        createTree(new Vector3(-19.94f, 1, -22.27f));
        createTree(new Vector3(-18.1f, 1, -22.88f));
        createTree(new Vector3(-16.13f, 1, -22.05f));

        createTree(new Vector3(-23.71f, 1, -19.47f));
        createTree(new Vector3(-21.75f, 1, -20.02f));
        createTree(new Vector3(-19.94f, 1, -19.27f));
        createTree(new Vector3(-18.1f, 1, -19.88f));
        createTree(new Vector3(-16.13f, 1, -19.05f));

        createTree(new Vector3(-23.71f, 1, -16.47f));
        createTree(new Vector3(-21.75f, 1, -17.02f));
        createTree(new Vector3(-19.94f, 1, -16.27f));
        createTree(new Vector3(-18.1f, 1, -16.88f));
        createTree(new Vector3(-16.13f, 1, -16.05f));

        createTree(new Vector3(-23.71f, 1, -13.47f));
        createTree(new Vector3(-21.75f, 1, -14.02f));
        createTree(new Vector3(-19.94f, 1, -13.27f));
        createTree(new Vector3(-18.1f, 1, -13.88f));
        createTree(new Vector3(-16.13f, 1, -13.05f));

        createTree(new Vector3(-23.71f, 1, -10.47f));
        createTree(new Vector3(-21.75f, 1, -11.02f));
        createTree(new Vector3(-19.94f, 1, -10.27f));
        createTree(new Vector3(-18.1f, 1, -10.88f));
        createTree(new Vector3(-16.13f, 1, -10.05f));

        createTree(new Vector3(-23.71f, 1, -7.47f));
        createTree(new Vector3(-21.75f, 1, -8.02f));
        createTree(new Vector3(-19.94f, 1, -7.27f));
        createTree(new Vector3(-18.1f, 1, -7.88f));
        createTree(new Vector3(-16.13f, 1, -7.05f));

        createTree(new Vector3(-23.71f, 1, -4.47f));
        createTree(new Vector3(-21.75f, 1, -5.02f));
        createTree(new Vector3(-19.94f, 1, -4.27f));
        createTree(new Vector3(-18.1f, 1, -4.88f));
        createTree(new Vector3(-16.13f, 1, -4.05f));

        createTree(new Vector3(-23.71f, 1, -1.47f));
        createTree(new Vector3(-21.75f, 1, -2.02f));
        createTree(new Vector3(-19.94f, 1, -1.27f));
        createTree(new Vector3(-18.1f, 1, -1.88f));
        createTree(new Vector3(-16.13f, 1, -1.05f));

        createTree(new Vector3(-23.71f, 1, 2.47f));
        createTree(new Vector3(-21.75f, 1, 1.02f));
        createTree(new Vector3(-19.94f, 1, 2.27f));
        createTree(new Vector3(-18.1f, 1, 2.88f));
        createTree(new Vector3(-16.13f, 1, 2.05f));

        createTree(new Vector3(-23.71f, 1, 5.47f));
        createTree(new Vector3(-21.75f, 1, 4.02f));
        createTree(new Vector3(-19.94f, 1, 5.27f));
        createTree(new Vector3(-18.1f, 1, 5.88f));
        createTree(new Vector3(-16.13f, 1, 5.05f));

        createTree(new Vector3(-23.71f, 1, 8.47f));
        createTree(new Vector3(-21.75f, 1, 7.02f));
        createTree(new Vector3(-19.94f, 1, 8.27f));
        createTree(new Vector3(-18.1f, 1, 8.88f));
        createTree(new Vector3(-16.13f, 1, 8.05f));

        createTree(new Vector3(-23.71f, 1, 11.47f));
        createTree(new Vector3(-21.75f, 1, 10.02f));
        createTree(new Vector3(-19.94f, 1, 11.27f));
        createTree(new Vector3(-18.1f, 1, 11.88f));
        createTree(new Vector3(-16.13f, 1, 11.05f));

        createTree(new Vector3(-23.71f, 1, 14.47f));
        createTree(new Vector3(-21.75f, 1, 13.02f));
        createTree(new Vector3(-19.94f, 1, 14.27f));
        createTree(new Vector3(-18.1f, 1, 14.88f));
        createTree(new Vector3(-16.13f, 1, 14.05f));

        createTree(new Vector3(-23.71f, 1, 17.47f));
        createTree(new Vector3(-21.75f, 1, 16.02f));
        createTree(new Vector3(-19.94f, 1, 17.27f));
        createTree(new Vector3(-18.1f, 1, 17.88f));
        createTree(new Vector3(-16.13f, 1, 17.05f));

        createTree(new Vector3(-23.71f, 1, 20.47f));
        createTree(new Vector3(-21.75f, 1, 19.02f));
        createTree(new Vector3(-19.94f, 1, 20.27f));
        createTree(new Vector3(-18.1f, 1, 20.88f));
        createTree(new Vector3(-16.13f, 1, 20.05f));

        createTree(new Vector3(-23.71f, 1, 23.47f));
        createTree(new Vector3(-21.75f, 1, 22.02f));
        createTree(new Vector3(-19.94f, 1, 23.27f));
        createTree(new Vector3(-18.1f, 1, 23.88f));
        createTree(new Vector3(-16.13f, 1, 23.05f));





        // OTHER SIDE 


        createTree(new Vector3(16.19f, 1, -22.47f));
        createTree(new Vector3(18.23f, 1, -23.02f));
        createTree(new Vector3(20.22f, 1, -22.27f));
        createTree(new Vector3(21.1f, 1, -22.88f));
        createTree(new Vector3(23.13f, 1, -22.05f));

        createTree(new Vector3(16.19f, 1, -19.47f));
        createTree(new Vector3(18.23f, 1, -20.02f));
        createTree(new Vector3(20.22f, 1, -19.27f));
        createTree(new Vector3(21.1f, 1, -19.88f));
        createTree(new Vector3(23.13f, 1, -19.05f));

        createTree(new Vector3(16.19f, 1, -16.47f));
        createTree(new Vector3(18.23f, 1, -17.02f));
        createTree(new Vector3(20.22f, 1, -16.27f));
        createTree(new Vector3(21.1f, 1, -16.88f));
        createTree(new Vector3(23.13f, 1, -16.05f));

        createTree(new Vector3(16.19f, 1, -13.47f));
        createTree(new Vector3(18.23f, 1, -14.02f));
        createTree(new Vector3(20.22f, 1, -13.27f));
        createTree(new Vector3(21.1f, 1, -13.88f));
        createTree(new Vector3(23.13f, 1, -13.05f));

        createTree(new Vector3(16.19f, 1, -10.47f));
        createTree(new Vector3(18.23f, 1, -11.02f));
        createTree(new Vector3(20.22f, 1, -10.27f));
        createTree(new Vector3(21.1f, 1, -10.88f));
        createTree(new Vector3(23.13f, 1, -10.05f));

        createTree(new Vector3(16.19f, 1, -7.47f));
        createTree(new Vector3(18.23f, 1, -8.02f));
        createTree(new Vector3(20.22f, 1, -7.27f));
        createTree(new Vector3(21.1f, 1, -7.88f));
        createTree(new Vector3(23.13f, 1, -7.05f));

        createTree(new Vector3(16.19f, 1, -4.47f));
        createTree(new Vector3(18.23f, 1, -5.02f));
        createTree(new Vector3(20.22f, 1, -4.27f));
        createTree(new Vector3(21.1f, 1, -4.88f));
        createTree(new Vector3(23.13f, 1, -4.05f));

        createTree(new Vector3(16.19f, 1, -1.47f));
        createTree(new Vector3(18.23f, 1, -2.02f));
        createTree(new Vector3(20.22f, 1, -1.27f));
        createTree(new Vector3(21.1f, 1, -1.88f));
        createTree(new Vector3(23.13f, 1, -1.05f));

        createTree(new Vector3(16.19f, 1, 2.47f));
        createTree(new Vector3(18.23f, 1, 1.02f));
        createTree(new Vector3(20.22f, 1, 2.27f));
        createTree(new Vector3(21.1f, 1, 2.88f));
        createTree(new Vector3(23.13f, 1, 2.05f));

        createTree(new Vector3(16.19f, 1, 5.47f));
        createTree(new Vector3(18.23f, 1, 4.02f));
        createTree(new Vector3(20.22f, 1, 5.27f));
        createTree(new Vector3(21.1f, 1, 5.88f));
        createTree(new Vector3(23.13f, 1, 5.05f));

        createTree(new Vector3(16.19f, 1, 8.47f));
        createTree(new Vector3(18.23f, 1, 7.02f));
        createTree(new Vector3(20.22f, 1, 8.27f));
        createTree(new Vector3(21.1f, 1, 8.88f));
        createTree(new Vector3(23.13f, 1, 8.05f));

        createTree(new Vector3(16.19f, 1, 11.47f));
        createTree(new Vector3(18.23f, 1, 10.02f));
        createTree(new Vector3(20.22f, 1, 11.27f));
        createTree(new Vector3(21.1f, 1, 11.88f));
        createTree(new Vector3(23.13f, 1, 11.05f));

        createTree(new Vector3(16.19f, 1, 14.47f));
        createTree(new Vector3(18.23f, 1, 13.02f));
        createTree(new Vector3(20.22f, 1, 14.27f));
        createTree(new Vector3(21.1f, 1, 14.88f));
        createTree(new Vector3(23.13f, 1, 14.05f));

        createTree(new Vector3(16.19f, 1, 17.47f));
        createTree(new Vector3(18.23f, 1, 16.02f));
        createTree(new Vector3(20.22f, 1, 17.27f));
        createTree(new Vector3(21.1f, 1, 17.88f));
        createTree(new Vector3(23.13f, 1, 17.05f));

        createTree(new Vector3(-23.71f, 1, 20.47f));
        createTree(new Vector3(18.23f, 1, 19.02f));
        createTree(new Vector3(20.22f, 1, 20.27f));
        createTree(new Vector3(21.1f, 1, 20.88f));
        createTree(new Vector3(23.13f, 1, 20.05f));

        createTree(new Vector3(-23.71f, 1, 23.47f));
        createTree(new Vector3(18.23f, 1, 22.02f));
        createTree(new Vector3(20.22f, 1, 23.27f));
        createTree(new Vector3(21.1f, 1, 23.88f));
        createTree(new Vector3(23.13f, 1, 23.05f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createTree(Vector3 position)
    {
        GameObject trunk = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        trunk.transform.parent = treeLocator.transform;
        trunk.transform.position = (position);
        trunk.transform.localScale = (new Vector3(0.5f, 1, 0.5f));
        trunk.transform.GetComponent<Renderer>().material.color = new Color(165/255f, 42/255f, 42/255f);

        GameObject leafs = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        leafs.transform.parent = trunk.transform;
        leafs.transform.localScale = new Vector3(4, 2, 4);
        leafs.transform.localPosition = (new Vector3(0, 0.95f, 0));
        leafs.transform.GetComponent<Renderer>().material.color = new Color(34/255f, 139/255f, 34/255f);
    }
}
