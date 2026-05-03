using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using System;
public class ShowButtonTrigger : MonoBehaviour
{
    [SerializeField] private GameObject InteractionButton;
    [SerializeField] private GameObject OpenCanvas;
    // Переменная для хранения новых созданных объектов блока
    private GameObject NewObject;
    private void Awake()
    {
        InteractionButton.SetActive(false);
    }

    // Если игрок подошел к предмету то показываем интерактивную кнопку
    private void OnTriggerEnter2D(Collider2D other)
    {
        InteractionButton.SetActive(true);
    }

    void Update()
    {
        GameObject MainGrid;
        GameObject MainPanel;
        int i;
        if (InteractionButton.activeSelf)
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                MainPanel = OpenCanvas.transform.Find("Panel").gameObject;
                MainGrid = MainPanel.transform.Find("Grid").gameObject;
                i = 1;
                OpenCanvas.SetActive(true);
                //Debug.Log(MainPanel.GetComponent<RectTransform>().rect.height / 16); 
                while (Math.Floor(MainPanel.GetComponent<RectTransform>().rect.width / 16) * Math.Floor(MainPanel.GetComponent<RectTransform>().rect.height / 16) > i)
                {
                    NewObject = Instantiate(MainGrid, MainGrid.transform.position, MainGrid.transform.rotation);
                    NewObject.transform.SetParent(MainPanel.transform, false);
                    i += 1;
                }
            }
        }
        
    }

    // Если игрок находится рядом с предметом
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.name=="Player")
    //    {
    //        eButtonUI.SetActive(true);
    //        Debug.Log("Игрок находится в триггере");
    //    }
    //}

    // Если игрок отошел от предмета то убираем интерактивную кнопку
    private void OnTriggerExit2D(Collider2D other)
    {
        InteractionButton.SetActive(false);
        Debug.Log(InteractionButton.activeSelf);

    }

}