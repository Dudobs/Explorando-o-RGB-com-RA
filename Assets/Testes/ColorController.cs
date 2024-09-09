using UnityEngine;

public class ColorController : MonoBehaviour
{
    public Color objectColor = Color.white;  // Expor a cor no Inspector

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectRenderer.material.color = objectColor;  // Inicializa a cor do material
    }

    void Update()
    {
        // Atualiza a cor do material com base na cor definida no Inspector
        objectRenderer.material.color = objectColor;
    }
}
