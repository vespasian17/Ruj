using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PolygonColliderHover : MonoBehaviour {

    // Use this for initialization
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver() {
        spriteRenderer.color = Color.blue;
    }

    void OnMouseExit() {
        spriteRenderer.color = Color.white;
    }
}
