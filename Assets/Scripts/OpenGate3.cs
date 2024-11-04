using UnityEngine;

public class OpenGate3 : MonoBehaviour
{
    public GameObject GateTrigger4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (GateTrigger4 != null)
            {
                GateTrigger4.SetActive(true);
            }
        }
    }
}