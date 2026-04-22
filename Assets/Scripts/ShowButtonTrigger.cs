using UnityEngine;

public class ShowButtonTrigger : MonoBehaviour
{
    [SerializeField] private GameObject InteractionButton;

    private void Awake()
    {
        InteractionButton.SetActive(false);
    }

    // Если игрок подошел к предмету то показываем интерактивную кнопку
    private void OnTriggerEnter2D(Collider2D other)
    {
        InteractionButton.SetActive(true);
        //Debug.Log("Вошли в триггер с: " + other.name);
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

    }

}