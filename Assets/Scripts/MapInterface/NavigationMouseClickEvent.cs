using UnityEngine;
using UnityEngine.UI;

public class NavigationMouseClickEvent : MonoBehaviour {
	
	[SerializeField] private SpriteRenderer _setBackgroundImage;
	private MapButtonsController _mapButtonsController;

	void Start () {
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		_mapButtonsController._backgroundContainer.sprite = _setBackgroundImage.sprite;
	}
	
	public void SetMapButtonsController(MapButtonsController controller)
	{
		_mapButtonsController = controller;
	}
}
