using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField]
    
    public float speed = 0.02f;
    private Vector3 direction;

    void Start()
    {
        int randomDire = Random.Range(0, 3);
        if (randomDire == 0)
        {
            direction = new Vector3(0, 0, -1);
        }
        else if (randomDire == 1)
        {
            direction = new Vector3(1, 0, -1);
        }
        else
        {
            direction = new Vector3(-1, 0, -1);
        }
    }

    void Update()
    {
        transform.position += direction * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Vector3 normal = collision.contacts[0].normal;
            Vector3 refl = Vector3.Reflect(direction, normal).normalized;
            int randomDire = Random.Range(0, 3);
            if (randomDire == 0)
            {
                direction = refl;
            }
            else if (randomDire == 1)
            {
                direction = refl + new Vector3(-1, 0, 0).normalized;
            }
            else
            {
                direction = refl + new Vector3(1, 0, 0).normalized;
            }
            direction.Normalize();
        }
        else if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}