using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    Color[] colors = new Color[3];
    int id;
    float currentTime;
    float startingTime;
    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.green;
        colors[1] = Color.yellow;
        colors[2] = Color.red;

        id = Random.Range(0, 3);

        if (id == 0)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[0];
            this.gameObject.tag = "Target";
            startingTime= Random.Range(5, 10);
            currentTime = startingTime;
        }
        if (id == 1)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[1];
            this.gameObject.tag = "Yellow";
            startingTime = 4;
            currentTime = startingTime;
        }
        if (id == 2)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[2];
            this.gameObject.tag = "Red";
            startingTime = Random.Range(5, 10);
            currentTime = startingTime;
        }
        else
        {
            Debug.Log(id);
        }
    }

    void changestate()
    {
        if (id == 0)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[1];
            this.gameObject.tag = "Yellow";
            startingTime = 4;
            currentTime = startingTime;

        }
        if (id == 1)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[2];
            this.gameObject.tag = "Red";
            startingTime = Random.Range(5, 10);
            currentTime = startingTime;
        }
        if (id == 2)
        {
            this.GetComponent<MeshRenderer>().material.color = colors[0];
            this.gameObject.tag = "Target";
            startingTime = Random.Range(5, 10);
            currentTime = startingTime;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (currentTime <= 0)
        {
            currentTime -= 1 *Time.deltaTime;
            Debug.Log(currentTime);
        }
        else
        {
            changestate();
        }
    }
}
