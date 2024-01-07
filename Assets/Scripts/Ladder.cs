using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 3f; // Скорость движения по лестнице
    public bool isOnLadder = false;

    void Update()
    {
        // Обработка ввода игрока или другие действия

        // Проверка, находится ли персонаж рядом с лестницей
        CheckForLadder();

        // Если персонаж на лестнице, обрабатываем ввод для перемещения вверх или вниз
        if (isOnLadder)
        {
            float verticalInput = Input.GetAxis("Vertical");
            ClimbLadder(verticalInput);
        }
    }

    void CheckForLadder()
    {
        // Создаем луч для определения лестницы
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 1, LayerMask.GetMask("Ladder"));

        // Проверяем, есть ли столкновение с лестницей
        isOnLadder = hit.collider != null;
    }

    void ClimbLadder(float input)
    {
        // Обработка движения по лестнице
        // Например, изменение позиции персонажа
        transform.Translate(new Vector2(0, 100));
    }
}
