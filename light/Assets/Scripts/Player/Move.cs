using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _Gravity;
    private CharacterController _characterController;
    private float _velocity = 0;
    private float _heightCharacter;
    
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _heightCharacter = _characterController.height;
    }

    private void FixedUpdate()
    {
        Movment();
        Squat();
    }

    private void Movment()
    {
        float _moveHorizontal = Input.GetAxis("Horizontal");
        float _moveVertical = Input.GetAxis("Vertical");

        Vector3 _move = transform.right * _moveHorizontal + transform.forward * _moveVertical;
        _characterController.Move(_move * (_speed * Time.deltaTime));
        
        if(_characterController.isGrounded)
        {
            _velocity = 0;
        }
        else
        {
            _velocity -= _Gravity * Time.deltaTime;
            _characterController.Move(new Vector3(0, _velocity, 0));
        }
    }

    private void Squat()
    {
        if (Input.GetKey("left ctrl"))
        {
            _characterController.height = _heightCharacter / 2;
        }
        else
        {
            _characterController.height = _heightCharacter;
        }
    }
}
