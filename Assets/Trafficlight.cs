using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trafficlight : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjects = 10;
    public float radius = 5f;
    private MeshRenderer meshRenderer;
    private float timeToChange = 0.1f;
    private float timeSinceChange = 0f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {

            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
            prefab.GetComponent<MeshRenderer>().sharedMaterial.SetColor("_Color", Color.green);
            meshRenderer = GetComponent<MeshRenderer>();
            /* prefab.material.color = Color.red;*/
        }
    }

    void update()
    {

            /*if(meshRenderer !=)*/
    }
}