using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;  // ��������� �� ��'��� ������
    public Vector3 offset;  // ������� ������ ������� ������
    public float camPositionSpeed = 5f;  // �������� ���� ������

    private void LateUpdate()
    {
        // ��������� ���� ������� ������ � ����������� ������� ������� ������ �� �������
        Vector3 newCamPosition = player.position + offset;

        // ������ ���������� ������ �� ���� �������
        transform.position = Vector3.Lerp(transform.position, newCamPosition, camPositionSpeed * Time.deltaTime);
    }
}

