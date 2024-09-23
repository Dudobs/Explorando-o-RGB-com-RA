using UnityEngine;
using UnityEngine.UI;  // Para usar os Sliders

public class ColorSliderController : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public GameObject redObject;
    public GameObject greenObject;
    public GameObject blueObject;

    private void Start()
    {
        // Inicializar os valores dos sliders com as cores atuais dos objetos
        redSlider.value = redObject.GetComponent<ColorController>().colorValue;
        greenSlider.value = greenObject.GetComponent<ColorController>().colorValue;
        blueSlider.value = blueObject.GetComponent<ColorController>().colorValue;

        // Adicionar listeners para atualizar as cores quando os sliders forem movidos
        redSlider.onValueChanged.AddListener(UpdateRedColor);
        greenSlider.onValueChanged.AddListener(UpdateGreenColor);
        blueSlider.onValueChanged.AddListener(UpdateBlueColor);
    }

    void UpdateRedColor(float value)
    {
        // Atualiza o valor vermelho do objeto e reflete a mudança
        redObject.GetComponent<ColorController>().colorValue = (int)value;
    }

    void UpdateGreenColor(float value)
    {
        // Atualiza o valor verde do objeto e reflete a mudança
        greenObject.GetComponent<ColorController>().colorValue = (int)value;
    }

    void UpdateBlueColor(float value)
    {
        // Atualiza o valor azul do objeto e reflete a mudança
        blueObject.GetComponent<ColorController>().colorValue = (int)value;
    }
}
