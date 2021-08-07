using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    private Renderer _quadRenderer;
    [SerializeField] private float _scrollSpeed = 0.5f;

    void Start()
    {
        _quadRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 textureOffset = new Vector2(0,Time.time*_scrollSpeed);
        _quadRenderer.material.mainTextureOffset = textureOffset;
    }
}
