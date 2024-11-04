using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform cel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = cel.position;
        }
    }
}
