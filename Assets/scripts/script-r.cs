using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public int redValue = 0; // Valor inicial da faixa vermelha (de 0 a 255)

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        SetRedColor(redValue);
    }

    void Update()
    {
        // Atualize o valor vermelho aqui, por exemplo, você pode usar o teclado para alterar o valor
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            redValue = Mathf.Clamp(redValue + 10, 0, 255);
            SetRedColor(redValue);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            redValue = Mathf.Clamp(redValue - 10, 0, 255);
            SetRedColor(redValue);
        }
    }

    void SetRedColor(int redValue)
    {
        // Normaliza o valor de 0 a 1, já que Unity usa valores de cor no intervalo de 0 a 1
        float normalizedRed = redValue / 255f;
        
        // Define a cor do objeto (vermelho, verde = 0, azul = 0)
        objectRenderer.material.color = new Color(normalizedRed, 0, 0);
    }
}
