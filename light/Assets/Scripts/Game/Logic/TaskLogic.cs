using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskLogic : MonoBehaviour
{
    [SerializeField] private List<TMP_Text> _tasks;

    private void Start()
    {
        foreach (var _task in _tasks)
        {
            Debug.Log(_task.text);
            Debug.Log(_task.gameObject.activeSelf);
        }
    }

    public void PickUpFlashlight()
    {
        _tasks[0].gameObject.SetActive(false);
        _tasks[1].gameObject.SetActive(true);
    }
}
