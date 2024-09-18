using UnityEngine;

public class ColorUpdater : MonoBehaviour
{
    public GameObject redObject;   // Referência ao objeto vermelho
    public GameObject greenObject; // Referência ao objeto verde
    public GameObject blueObject;  // Referência ao objeto azul

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Pega os valores de cor dos objetos vermelho, verde e azul
        float redValue = redObject.GetComponent<ColorController>().colorValue / 255f;
        float greenValue = greenObject.GetComponent<ColorController>().colorValue / 255f;
        float blueValue = blueObject.GetComponent<ColorController>().colorValue / 255f;

        // Atualiza a cor do quarto GameObject com base nos valores R, G e B
        objectRenderer.material.color = new Color(redValue, greenValue, blueValue);
    }
}
