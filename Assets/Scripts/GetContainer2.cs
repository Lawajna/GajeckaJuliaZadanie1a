using UnityEngine;

public class GetContainer2 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Container3;

    private bool isContainerActive = false;

    void Start()
    {
        if (Container3 != null)
        {
            Container3.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10))
            {
                if (hit.collider.gameObject == Enemy1)
                {
                    Enemy1.SetActive(false);
                }
                else if (hit.collider.gameObject == Enemy2)
                {
                    Enemy2.SetActive(false);
                }
                else if (hit.collider.gameObject == Enemy3)
                {
                    Enemy3.SetActive(false);
                }
                else if (hit.collider.gameObject == Container3 && isContainerActive)
                {
                    Container3.SetActive(false);
                    isContainerActive = false;
                }
            }
        }
        if (!Enemy1.activeSelf && !Enemy2.activeSelf && !Enemy3.activeSelf && !isContainerActive)
        {
            Container3.SetActive(true);
            isContainerActive = true;
        }
    }
}
