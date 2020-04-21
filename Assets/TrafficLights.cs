using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    Material m_Material;
    public int numberOfObjects = 10;
    public float radius = 5f;
    private MeshRenderer meshRenderer;
    float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.green;
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
            /*prefab.GetComponent<MeshRenderer>().sharedMaterial.SetColor("_Color", Color.green);
            meshRenderer = GetComponent<MeshRenderer>();*/
            /* prefab.material.color = Color.red;*/
        }
        prefab = GetComponent<GameObject>();
        m_Material = GetComponent<Renderer>().material;
    }

    void update()
    {
        
    }
}