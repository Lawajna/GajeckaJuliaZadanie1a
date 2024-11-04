using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public GameObject GateTrigger2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (GateTrigger2 != null)
            {
                GateTrigger2.SetActive(true);
            }
        }
    }
}