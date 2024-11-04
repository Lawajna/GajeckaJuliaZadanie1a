using UnityEngine;

public class GetContainer : MonoBehaviour
{
    public GameObject Container;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (Container != null)
            {
                Container.SetActive(true);
            }
        }
    }
}