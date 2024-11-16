using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;        // ������ �� ������ ������
    public Vector3 offset;          // �������� ������ ������������ ������
    public float camPositionSpeed = 10f; // �������� ����������� ������

    private void LateUpdate()
    {
        // ��������, ����� �������� �������� ����� ���� ��� ��������
        if (camPositionSpeed <= 0f)
        {
            Debug.LogWarning("camPositionSpeed ������ ���� ������ 0");
            return;
        }

        // ��������� ������� ������� ������ ������������ ������� ������ � ��������
        Vector3 newCamPosition = player.position + offset;

        // ������� ����������� ������ � ����� �������
        transform.position = Vector3.Lerp(transform.position, newCamPosition, camPositionSpeed * Time.deltaTime);
    }
}



