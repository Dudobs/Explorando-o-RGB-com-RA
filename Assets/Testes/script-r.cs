using UnityEngine;

public class ColorUpdater : MonoBehaviour
{
    public GameObject redObject;   // Referência ao GameObject vermelho
    public GameObject greenObject; // Referência ao GameObject verde
    public GameObject blueObject;  // Referência ao GameObject azul

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Pega as cores dos objetos R, G e B
        Color redColor = redObject.GetComponent<ColorController>().objectColor;
        Color greenColor = greenObject.GetComponent<ColorController>().objectColor;
        Color blueColor = blueObject.GetComponent<ColorController>().objectColor;

        // Atualiza a cor do quarto GameObject com base nas cores R, G e B
        objectRenderer.material.color = new Color(redColor.r, greenColor.g, blueColor.b);
    }
}
