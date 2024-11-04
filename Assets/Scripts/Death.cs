using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
          {
            Destroy(other.gameObject);
            Debug.Log("Koniec gry!");
            Application.Quit();
          }
    }
}