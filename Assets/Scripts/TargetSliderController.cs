using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class TargetSliderController : MonoBehaviour
{
    // Slidres
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    // Textos dos sliders
    public Text redValueText;
    public Text greenValueText;
    public Text blueValueText;
    public Text RGBValueText;
    public Text RGBRedValueText;
    public Text RGBGreenValueText;
    public Text RGBBlueValueText;

    // Objetos que representam as cores
    public GameObject redObject;
    public GameObject greenObject;
    public GameObject blueObject;

    // Targets de cor
    public GameObject redTarget;
    public GameObject greenTarget;
    public GameObject blueTarget;
    public GameObject RGBTarget;

    private void Start()
    {
        // Inicializa todos os sliders e textos como invisíveis
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
        RGBValueText.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor vermelha é detectado
    public void OnRedTargetFound()
    {
        redSlider.gameObject.SetActive(true);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor verde é detectado
    public void OnGreenTargetFound()
    {
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(true);
        blueSlider.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor azul é detectado
    public void OnBlueTargetFound()
    {
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(true);
    }

    public void OnRGBTargetFound()
    {
        RGBValueText.gameObject.SetActive(true);
    }

    // Função chamada quando nenhum target é detectado
    public void OnTrackingLost()
    {
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
        RGBValueText.gameObject.SetActive(false);

    }

    // Atualiza os textos dos sliders com os valores atuais (0-255)
    private void UpdateSliderValueTexts()
    {
        redValueText.text = ((int)redSlider.value).ToString();
        RGBRedValueText.text = ((int)redSlider.value).ToString();
        greenValueText.text = ((int)greenSlider.value).ToString();
        RGBGreenValueText.text = ((int)greenSlider.value).ToString();
        blueValueText.text = ((int)blueSlider.value).ToString();
        RGBBlueValueText.text = ((int)blueSlider.value).ToString();
    }

    // Atualiza os textos quando os sliders são modificados
    public void OnSliderValueChanged()
    {
        UpdateSliderValueTexts();
    }
}
