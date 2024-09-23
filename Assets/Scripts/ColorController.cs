using UnityEngine;

public class ColorController : MonoBehaviour
{
    [Range(0, 255)] public int colorValue = 0; // Controla o valor de cor (R para vermelho, G para verde, B para azul)
    public bool isRed, isGreen, isBlue; // Define se é o objeto vermelho, verde ou azul

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        UpdateColor();
    }

    void Update()
    {
        UpdateColor();
    }

    void UpdateColor()
    {
        // Inicializa as cores com o mínimo, exceto o canal controlado pelo objeto
        float red = isRed ? colorValue / 255f : 0f;
        float green = isGreen ? colorValue / 255f : 0f;
        float blue = isBlue ? colorValue / 255f : 0f;

        // Atualiza a cor do material do objeto
        objectRenderer.material.color = new Color(red, green, blue);
    }
}
