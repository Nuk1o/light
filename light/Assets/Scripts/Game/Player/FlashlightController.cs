using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private GameObject _flashlight;
    private GameObject _flash;
    private GameObject _ultraviolet;
    private GameObject _battery;
    private Camera _camera;
    private Vector3 _cameraAxes;
    
    private void Start()
    {
        _flashlight = gameObject;
        _camera = Camera.main;
        _flash = _flashlight.transform.GetChild(0).gameObject;
        _ultraviolet = _flashlight.transform.GetChild(1).gameObject;
        _battery = _flashlight.transform.GetChild(2).gameObject;
    }

    private void Update()
    {
        SwitchingFlashlight();
    }

    private void SwitchingFlashlight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            string _flashSwitch = PlayerPrefs.GetString("flash","light");
            if (BatteryIsReady())
            {
                switch (_flashSwitch)
                {
                    case "light":
                        OnOffLight();
                        break;
                    case "ultraviolet":
                        OnOffUltraviolet();
                        break;
                    default:
                        Debug.Log("Error Flash");
                        break;
                }
            }
        }

        if (!BatteryIsReady())
        {
            _flash.SetActive(false);
            _ultraviolet.SetActive(false);
        }
    }

    private bool BatteryIsReady()
    {
        return _battery.activeSelf;
    }

    private void OnOffLight()
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
    
    private void OnOffUltraviolet()
    {
        if (_ultraviolet.activeSelf)
        {
            _ultraviolet.SetActive(false);
        }
        else
        {
            _ultraviolet.SetActive(true);
        }
    }
}
