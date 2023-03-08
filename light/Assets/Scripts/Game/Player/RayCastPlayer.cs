using UnityEngine;

public class RayCastPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _helpUI;
    [SerializeField] private FlashlightController _flashlightController;
    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) {
            if (hit.collider.gameObject.tag == "Ultraviolet")
            {
                _helpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    _flashlightController._fSwitch = "ultraviolet";
                    Destroy(hit.collider.gameObject);
                }
            }
            else
            {
                _helpUI.SetActive(false);
            }
        }
    }
}
