using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        // ������������� ������� ���� �������� ������
        Quaternion targetRotation = Quaternion.Euler(50f, -120f, 0f);

        // ������������� ������ � ������ �������� � ���� ��������
        Vector3 desiredPosition = player.position - targetRotation * offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // ������������� ���� �������� ��������
        transform.rotation = targetRotation;
    }
}
