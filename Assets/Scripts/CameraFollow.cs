using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // —сылка на Transform персонажа, за которым следит камера
    public float smoothSpeed = 1f; // ѕлавность следовани€ камеры
    public GameObject mapBounds;
    public GameObject mapBounds2;


    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }

   
}
