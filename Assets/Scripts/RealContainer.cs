using UnityEngine;
public class RealContainer : MonoBehaviour
{
    private Renderer containerRenderer;
    private bool isCollided = false;
    void Start()
    {
        containerRenderer = GetComponent<Renderer>();
    }
 void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            containerRenderer.material.color = Color.green;
            isCollided = true; 
        }
    }
     void Update()
    {
        if (isCollided && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    gameObject.SetActive(false);
                    UnityEditor.EditorApplication.isPlaying = false;
                }
            }
        }
    }
}