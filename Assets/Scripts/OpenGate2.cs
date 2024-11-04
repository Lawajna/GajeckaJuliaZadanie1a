using UnityEngine;

public class OpenGate2 : MonoBehaviour
{
    public GameObject GateTrigger3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (GateTrigger3 != null)
            {
                GateTrigger3.SetActive(true);
            }
        }
    }
}