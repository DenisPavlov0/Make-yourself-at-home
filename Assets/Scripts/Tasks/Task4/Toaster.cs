using System;
using UnityEngine;
using UnityEngine.Events;

public class Toaster : MonoBehaviour
{
    // TODO: Создайте событие TimerIsUp и вызывайте его, когда таймер вышел

    public float Timer { get; private set; } = 5; // Таймер готовности вафли
    private bool _isTimerUp;
    public UnityEvent TimerIsUp;

    private void Start()
    {
        if (TimerIsUp == null)
        {
            TimerIsUp = new UnityEvent();
        }
           
    }

    private void Update()
    {
        // Если таймер вышел - выходим из метода
        if (_isTimerUp)
        {
            return;
        }
        
        // Если таймер не вышел
        if (Timer > 0)
        {
            // Отнимаем время, прошедшее за кадр
            Timer -= Time.deltaTime;
        }
        else
        {
            // Таймер вышел
            _isTimerUp = true;
            TimerIsUp.Invoke();
        }
    }
}