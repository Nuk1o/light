using UnityEngine;

public class LiftingItem : MonoBehaviour
{
    [SerializeField] private GameObject _liftItem;
    [SerializeField] private GameObject _item;
    [SerializeField] private GameObject _helpUI;
    [SerializeField] private string _pickUpItem;
    [SerializeField] private TaskLogic _taskLogic;

    private void OnTriggerEnter(Collider other)
    {
        _helpUI.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("The subject is raised");
            _helpUI.SetActive(false);
            _item.SetActive(true);
            PickUp();
            Destroy(_liftItem);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _helpUI.SetActive(false);
    }

    private void PickUp()
    {
        switch (_pickUpItem)
        {
            case "flashlight":
                _taskLogic.PickUpFlashlight();
                break;
            default:
                Debug.Log("Something's wrong");
                break;
        }
    }
}
