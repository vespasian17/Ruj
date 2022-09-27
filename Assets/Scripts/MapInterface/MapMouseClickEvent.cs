using UnityEngine;

public class MapMouseClickEvent : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _setBackgroundImage;
    [SerializeField] private GameObject _navigationButtons;
    private MapButtonsController _mapButtonsController;

    void OnMouseDown()
    {
        _mapButtonsController._backgroundContainer.sprite = _setBackgroundImage.sprite;
        _mapButtonsController._mapObjects.SetActive(false);
        _mapButtonsController._backgroundContainer.gameObject.SetActive(true);
        _mapButtonsController._interfaceButtons.gameObject.SetActive(true);
        _mapButtonsController._navigationButtonPanel.gameObject.SetActive(true);
        if (_navigationButtons != null) _navigationButtons.gameObject.SetActive(true);
    }

    public void SetMapButtonsController(MapButtonsController controller)
    {
        _mapButtonsController = controller;
    }
}
