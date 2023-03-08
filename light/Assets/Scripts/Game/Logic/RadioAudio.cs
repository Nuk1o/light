using UnityEngine;

public class RadioAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private GameObject _battery;

    private void Start()
    {
        _battery = gameObject.transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if (_battery.activeSelf)
        {
            _audioSource.Play();
        }
    }
}
