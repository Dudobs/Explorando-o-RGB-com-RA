using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class TargetSliderController : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Text redValueText;
    public Text greenValueText;
    public Text blueValueText;

    public GameObject redObject;
    public GameObject greenObject;
    public GameObject blueObject;

    // Referência ao ImageTarget do Vuforia
    public GameObject redTarget;
    public GameObject greenTarget;
    public GameObject blueTarget;

    private void Start()
    {
        // Inicializa todos os sliders como invisíveis
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor vermelha é detectado
    public void OnRedTargetFound()
    {
        Debug.Log("Red target found");
        redSlider.gameObject.SetActive(true);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor verde é detectado
    public void OnGreenTargetFound()
    {
        Debug.Log("Green target found");
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(true);
        blueSlider.gameObject.SetActive(false);
    }

    // Função chamada quando o target de cor azul é detectado
    public void OnBlueTargetFound()
    {
        Debug.Log("Blue target found");
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(true);
    }

    // Função chamada quando nenhum target é detectado
    public void OnTrackingLost()
    {
        redSlider.gameObject.SetActive(false);
        greenSlider.gameObject.SetActive(false);
        blueSlider.gameObject.SetActive(false);
    }

    // Atualiza os textos dos sliders com os valores atuais (0-255)
    private void UpdateSliderValueTexts()
    {
        redValueText.text = ((int)redSlider.value).ToString();
        greenValueText.text = ((int)greenSlider.value).ToString();
        blueValueText.text = ((int)blueSlider.value).ToString();
    }

    // Atualiza os textos quando os sliders são modificados
    public void OnSliderValueChanged()
    {
        UpdateSliderValueTexts();
    }
}
