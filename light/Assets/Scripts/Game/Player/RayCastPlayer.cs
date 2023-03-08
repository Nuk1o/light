using UnityEngine;

public class RayCastPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _helpUI;
    [SerializeField] private FlashlightController _flashlightController;
    [SerializeField] private GameObject _ultraviolet;
    [SerializeField] private GameObject _palet;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _gameObject2;
    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) {
            if (hit.collider.gameObject.tag == "Ultraviolet" && _ultraviolet.transform.parent.gameObject.activeSelf)
            {
                
                _helpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    _flashlightController._fSwitch = "ultraviolet";
                    Destroy(hit.collider.gameObject);
                    _helpUI.SetActive(false);
                }
            }

            if (hit.collider.gameObject.tag == "TextUltraviolet"&&_ultraviolet.activeSelf)
            {
                hit.collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                _palet.SetActive(false);
            }

            if (hit.collider.gameObject.tag == "Key"&&_ultraviolet.activeSelf)
            {
                _helpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    Destroy(hit.collider.gameObject);
                    _helpUI.SetActive(false);
                }
                _gameObject.SetActive(false);
                _gameObject2.SetActive(true);
            }
        }
    }
}
