using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjects = 10;
    public float radius = 5f;
    public GameObject Boid;
    //private float timeToChange = 0.1f;
    //private float timeSinceChange = 0f;
    //static public List gList;
    void Start()
    {
       // glist = new List<prefab>();
        for (int i = 0; i < numberOfObjects; i++)
        {

            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            GameObject lights = Instantiate(prefab, pos, rot);
            //prefab.gameObject.AddComponent<UnityEngine.MeshRenderer>();
            //glist.Add(lights);
            //prefab.GetComponent<MeshRenderer>().sharedMaterial.SetColor("_Color", Color.green);
            /* prefab.material.color = Color.red;*/
        }
        GameObject boid = Instantiate(Boid);

    }

    void update()
    {

            /*if(meshRenderer !=)*/
    }
}