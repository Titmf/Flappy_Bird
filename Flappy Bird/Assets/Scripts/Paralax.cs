 using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] private float animationSpeed = 1f;
    
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        _meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}