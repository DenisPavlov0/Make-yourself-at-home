using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    [SerializeField] private Waffle _waffle;

    [SerializeField] private Transform _parent;

    [SerializeField] private Toaster _toaster;
    
    
    private void Start()
    {
        _toaster.TimerIsUp.AddListener(CreateWaffle);
    }

    private void CreateWaffle()
    {
        Instantiate(_waffle, _parent);
    }

    


    
}