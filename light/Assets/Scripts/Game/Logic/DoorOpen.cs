using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            _animator.SetBool("open",true);
            _audioSource.Play();
        }
    }
}
