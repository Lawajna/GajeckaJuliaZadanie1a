using UnityEngine;

public class OpenTeleport : MonoBehaviour
{
    public GameObject teleport;

    void OnMouseDown()
    {
        if (gameObject.CompareTag("container"))
        {
            gameObject.SetActive(false);
        }

        if (teleport != null)
        {
            teleport.SetActive(true);
        }
    }
}