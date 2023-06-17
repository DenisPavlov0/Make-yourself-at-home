using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private Lamp[] _lamp;

    private void Start()
    {
        _lamp = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (_lamp != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                foreach (var lamp in _lamp)
                {
                    lamp.Interact();
                }
            }
        }
    }
}