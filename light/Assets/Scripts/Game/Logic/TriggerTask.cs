using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerTask : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject1;
    [SerializeField] private GameObject _gameObject2;
    [SerializeField] private string _text;
    [SerializeField] private GameObject _uIHelp;
    [SerializeField] private GameObject _uIText;
    [SerializeField] private AudioSource _audioSource;

    private bool _taskBool;
    private bool _taskBool2;

    private void Start()
    {
        _taskBool = false;
        _taskBool2 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_uIHelp != null)
        {
            _uIHelp.SetActive(true);
        }
        if (_text == "stairs")
        {
            if (!_gameObject1.activeSelf)
            {
                other.transform.position = new Vector3(-4.27199984f,4.08900023f,-0.079999998f);
            }
        }   
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (_text)
            {
                case "radio":
                    actionRadio();
                    break;
                case "doorClose":
                    actionDoorClose();
                    break;
                case "doorOpen":
                    break;
                default:
                    Debug.Log("Trigger error");
                    break;
            }
        }
        if (Input.GetKeyDown(KeyCode.G)&&_taskBool2)
        {
            _gameObject1.SetActive(true);
            _gameObject2.SetActive(false);
            _taskBool = true;
            _taskBool2 = false;
            _audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_uIHelp != null)
        {
            _uIHelp.SetActive(false);
        }   
    }
    
    private void actionRadio()
    {
        if (!_taskBool && !_gameObject1.activeSelf && _gameObject2.activeSelf)
        {
            _uIText.SetActive(true);
            TMP_Text _textTMP = _uIText.GetComponent<TMP_Text>();
            _textTMP.text = $"You need to insert the battery \n Press G";
            StartCoroutine(TextCorutine(_uIText));
            _taskBool2 = true;
        }

        if (_taskBool)
        {
            _uIText.SetActive(true);
            TMP_Text _textTMP = _uIText.GetComponent<TMP_Text>();
            _textTMP.text = $"Pick up the battery\n";
            StartCoroutine(TextCorutine(_uIText));
            _gameObject1.SetActive(false);
            _gameObject2.SetActive(true);
            _taskBool = false;
            _taskBool2 = false;
        }
    }

    private void actionDoorClose()
    {
        TMP_Text _text = _uIText.GetComponent<TMP_Text>();
        _text.text = "Close door";
        _uIText.SetActive(true);
        _audioSource.Play();
        StartCoroutine(TextCorutine(_uIText));
    }

    IEnumerator TextCorutine(GameObject _go)
    {
        yield return new WaitForSeconds(2);
        _go.SetActive(false);
    }
}

