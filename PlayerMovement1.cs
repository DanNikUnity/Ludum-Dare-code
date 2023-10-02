using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 5f;           // Скорость движения
    public float rotationSpeed = 500f; // Скорость поворота
    public Animator animator;
    public bool running;
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Вычисляем направление движения в локальных координатах камеры
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0f; // Убедимся, что движение по вертикали равно 0

        // Если есть входные данные, двигаем игрока
        if (Mathf.Abs(horizontalInput) >= 0.1f || Mathf.Abs(verticalInput) >= 0.1f)
        {
            // Поворот игрока
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

            // Движение игрока
            transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
            running = true;
        }
        else
        {
            // Если игрок не двигается, устанавливаем running в false
            running = false;
        }

        if (running)
        {
            animator.SetBool("running", true);
        }
        else animator.SetBool("running", false);
    }

    void Move()
    {
        
    }
}
