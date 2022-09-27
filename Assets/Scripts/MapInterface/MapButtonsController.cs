using UnityEngine;

public class MapButtonsController : MonoBehaviour
{
    [field:SerializeField] public SpriteRenderer _backgroundContainer { get; private set; }
    [field:SerializeField] public GameObject _navigationButtonPanel { get; private set; }
    [field:SerializeField] public GameObject _interfaceButtons { get; private set; }
    [field:SerializeField] public GameObject _mapObjects { get; private set; }

    private void Start()
    {
        MapMouseClickEvent[] mouseClickEvents = FindObjectsOfType<MapMouseClickEvent>(true);
        NavigationMouseClickEvent[] mouseNavClickEvents = FindObjectsOfType<NavigationMouseClickEvent>(true);
        foreach (var mouseClickEvent in mouseClickEvents)
        {
            mouseClickEvent.SetMapButtonsController(this);
        }
        foreach (var mouseNavClickEvent in mouseNavClickEvents)
        {
            mouseNavClickEvent.SetMapButtonsController(this);
        }
    }
}
