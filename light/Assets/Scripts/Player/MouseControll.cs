using UnityEngine;

public class MouseControll : MonoBehaviour
{
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private Transform _playerBody;
    private float _xRotation = 0.0f;
    private float _yRotation = 0.0f;
    private Camera _camera;

    
    void Start()
    {
        _camera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * _verticalSpeed;

        _yRotation += mouseX;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(_xRotation,0,0);

        _camera.transform.eulerAngles = new Vector3(_xRotation, _yRotation, 0.0f);
        
        _playerBody.Rotate(Vector3.up * mouseX);
    }
}
