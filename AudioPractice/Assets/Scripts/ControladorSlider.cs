using UnityEngine;
using UnityEngine.UI;

public class ControladorSlider : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private AjustesAudio storage;
    void Start()
    {
        slider.value = storage.volumen;
        slider.onValueChanged.AddListener(ajustarValor);
    }

    void ajustarValor( float valor)
    {
        storage.volumen = valor;
    }
}