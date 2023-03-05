using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private GameObject _flashlight;
    private GameObject _flash;
    private Camera _camera;
    private Vector3 _cameraAxes;
    
    private void Start()
    {
        _flashlight = gameObject;
        _camera = Camera.main;
        _flash = _flashlight.transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        SwitchingFlashlight();
    }

    private void SwitchingFlashlight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_flash.activeSelf)
            {
                _flash.SetActive(false);
            }
            else
            {
                _flash.SetActive(true);
            }
        }
    }
}
