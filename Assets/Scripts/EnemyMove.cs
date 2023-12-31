using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target; 
    public float speed = 5f;

    public Transform targetP1;
    public Transform targetP2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("p2"))
        {
            target = targetP1;                    
        }
        else if(collision.CompareTag("p1"))
        {
            target = targetP2;
        }

        if(collision.CompareTag("p2") || collision.CompareTag("p1"))
        {
            Vector3 currentScale = transform.localScale;

            // �������� ����������� �� �����������, ������� ������� ������� �� -1 �� ��� X
            currentScale.x *= -1;

            // ��������� ������ ��������
            transform.localScale = currentScale;
        }
    }

    private void Start()
    {
        target = targetP2;
    }

    void Update()
    {        
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        if (target != null)
        {
            // ����������� � ������ ����������
            Vector3 direction = target.position - transform.position;

            // ������������ ������� ����������� (������ ��� ������ 1)
            direction.Normalize();

            // ����������� ������� � ����������� ������ ����������
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
