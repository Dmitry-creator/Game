using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    // Получаем доступ к аниматору для получения параметра IsRunning
    private Animator animator;
    // Получаем доступ к cпрайту для дальнейшей обработки
    private SpriteRenderer spriteRenderer;
    // Константа для переменной IS_RUNNING в аниматоре
    private const string IS_RUNNING = "IsRunning";


    private void Awake()
    {
        // Инициализация аниматора
        animator = GetComponent<Animator>();

        // Инициализация спрайта
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Обновление переменной в аниматоре для использования другой анимации
        animator.SetBool(IS_RUNNING, Player.Instance.IsRunning());
        if (Player.Instance.IsDirection() == "Left")
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
