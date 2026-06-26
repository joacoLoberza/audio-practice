using UnityEngine;

public class AjustarVolumen : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AjustesAudio storage;
    void Update()
    {
        source.volume = storage.volumen;
    }
}
