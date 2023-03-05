using System;
using UnityEngine;

public class LiftingItem : MonoBehaviour
{
    [SerializeField] private GameObject _liftItem;
    [SerializeField] private GameObject _item;
    [SerializeField] private GameObject _helpUI;

    private void OnTriggerEnter(Collider other)
    {
        _helpUI.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Предмет поднят");
            _helpUI.SetActive(false);
            _item.SetActive(true);
            Destroy(_liftItem);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _helpUI.SetActive(false);
    }
}
