using System.Collections;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _end;
    [SerializeField] private GameObject _endUI;
    [SerializeField] private GameObject _camera;

    private void OnTriggerEnter(Collider other)
    {
        _audioSource.Play();
        _player.SetActive(false);
        _end.SetActive(true);
        _camera.SetActive(true);
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(1);
        _endUI.SetActive(true);
        _end.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
