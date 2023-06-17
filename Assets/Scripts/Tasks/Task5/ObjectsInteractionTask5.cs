using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    
    [SerializeField] private Shelf _shelf;
    [SerializeField] private Shelf _shelf2;

    private void Start()
    {
        _shelf.ItemSpawned += FallingShelves;
    }

    private void FallingShelves()
    {
        if (_shelf != null && _shelf2 != null)
        {
            _shelf.Fall();
            _shelf2.Fall();
        }
        
    }
}