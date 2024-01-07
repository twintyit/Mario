using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 3f; // �������� �������� �� ��������
    public bool isOnLadder = false;

    void Update()
    {
        // ��������� ����� ������ ��� ������ ��������

        // ��������, ��������� �� �������� ����� � ���������
        CheckForLadder();

        // ���� �������� �� ��������, ������������ ���� ��� ����������� ����� ��� ����
        if (isOnLadder)
        {
            float verticalInput = Input.GetAxis("Vertical");
            ClimbLadder(verticalInput);
        }
    }

    void CheckForLadder()
    {
        // ������� ��� ��� ����������� ��������
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 1, LayerMask.GetMask("Ladder"));

        // ���������, ���� �� ������������ � ���������
        isOnLadder = hit.collider != null;
    }

    void ClimbLadder(float input)
    {
        // ��������� �������� �� ��������
        // ��������, ��������� ������� ���������
        transform.Translate(new Vector2(0, 100));
    }
}
