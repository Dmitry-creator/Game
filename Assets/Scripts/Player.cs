using UnityEngine;

public class Player : MonoBehaviour
{
    // Создание одноразового класса для использование этого класса в другом
    public static Player Instance { get; private set; }

    // Скорость персонажа
    [SerializeField] private float movingSpeed;
    
    private Rigidbody2D rb;

    // Минимальная возможная скорость персонажа 
    private float minMovingSpeed = 0.1f;

    // Ключ для обработки действия персонажа стоит он на месте или бежит
    private bool isRunning = false;

    // Переменная для обработки действия персонажа для считывания в какую сторону он бежит
    private string isDirection = "";

    private void Awake()
    {
        // Создаем единственный экземпляр класса. this ссылка на текущий экземпляр класса в котором выполняется код
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        HandleMovement();

    }

    //  Функция для обработки действий ручного движения персонажа
    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (movingSpeed * Time.fixedDeltaTime));
        //Debug.Log(inputVector);

        // Считывание и запись в переменную того куда персонаж бежит
        if (inputVector.x == 1.0)
        {
            isDirection = "Right";
        }
        if (inputVector.x == -1.0)
        {
            isDirection = "Left";
        }

        // Проверяем бежит персонаж или стоит на месте
        if (Mathf.Abs(inputVector.x) > minMovingSpeed || Mathf.Abs(inputVector.y) > minMovingSpeed)
        {
            isRunning = true;
        }
        else{
            isRunning = false;
        }
    }

    // Функция возвращает лож-персонаж стоит истина-персонаж бежит
    public bool IsRunning()
    {
        return isRunning;
    }

    // Функция возвращает направления движения персонажа
    public string IsDirection()
    {
        return isDirection;
    }
}
