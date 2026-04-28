using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerationMap : MonoBehaviour
{

    // Возможные объекты блоков загатавливыемые в сцене
    public GameObject[] objects;
    private float postionX;
    private float postionY;
    private int i;
    // Переменная для генерациия рандомного блока
    private int rand;
    // Список объектов блоков
    private List<ClassBloksObject> NewBloksObject = new List<ClassBloksObject>();
    // Переменная для хранения новых созданных объектов блока
    private GameObject NewObject;
    // Кол-во блоков в мире
    private const int CountBloks = 100;
    // Кол-во рядов блоков (глубина мира)
    private const int CountRow = 5;
    // Размер блока
    private const double SizeBlock = 0.75;
    // Стартовая Х координата мира
    private const int InitialCoordinateX = -6;
    // Стартовая Y координата мира
    private const int InitialCoordinateY = -2;
    void Start()
    {
        i = 0;
        postionX = InitialCoordinateX;
        postionY = InitialCoordinateY;
        while (i < CountBloks)
        {
            rand = Random.Range(0, objects.Length);
            while (NewBloksObject.Count(j => j.Name=="Blok 2" ) == 8 & rand == 2)
            {
                rand = Random.Range(0, objects.Length);
            }


            if (i%(CountBloks/CountRow)==0 & i!=0)
            {
                postionY -= (float)(SizeBlock);
                postionX = InitialCoordinateX;
            }
            postionX += (float)(SizeBlock);
            NewObject = Instantiate(objects[rand], objects[rand].transform.position = new Vector2(postionX, postionY), objects[rand].transform.rotation);
            NewBloksObject.Add(new ClassBloksObject(objects[rand].name, NewObject.GetComponent<SpriteRenderer>().color, NewObject));
            Debug.Log(NewBloksObject[^1].Name);
            Debug.Log(NewBloksObject[^1].Color);
            NewBloksObject[^1].GameObject.SetActive(true);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}