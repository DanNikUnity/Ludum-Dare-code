using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 5f;           // �������� ��������
    public float rotationSpeed = 500f; // �������� ��������
    public Animator animator;
    public bool running;
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ��������� ����������� �������� � ��������� ����������� ������
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0f; // ��������, ��� �������� �� ��������� ����� 0

        // ���� ���� ������� ������, ������� ������
        if (Mathf.Abs(horizontalInput) >= 0.1f || Mathf.Abs(verticalInput) >= 0.1f)
        {
            // ������� ������
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

            // �������� ������
            transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
            running = true;
        }
        else
        {
            // ���� ����� �� ���������, ������������� running � false
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
