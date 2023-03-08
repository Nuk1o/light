using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(-4.27199984f,4.08900023f,-0.079999998f);
    }
}
