using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerationMap : MonoBehaviour
{

    public GameObject[] objects;
    private float postionX;
    private float postionY;
    private GameObject[] NewObjects;
    private int i;
    private int rand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewObjects = new GameObject[40];
        i = 0;
        postionX = -6;
        postionY = -2;
        while (i < 40)
        {
            int j;
            int CountObject2=0;
            rand = Random.Range(0, objects.Length);
            if (CountObject2 < 5)
            {

                for (j = 0;  j<= i-1; j++)
                {
                    if (objects[2].name == NewObjects[j].name)
                    {
                        CountObject2 += 1;
                    }
                }
            }
            while (CountObject2 == 5 & rand == 2)
            {
                rand = Random.Range(0, objects.Length);
            }


            if (i == 20)
            {
                postionY += (float)(0.75);
                postionX = -6;
            }
            postionX += (float)(0.75);
            NewObjects[i] = Instantiate(objects[rand], objects[rand].transform.position = new Vector2(postionX, postionY), objects[rand].transform.rotation);
            NewObjects[i].name = objects[rand].name;
            NewObjects[i].SetActive(true);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}