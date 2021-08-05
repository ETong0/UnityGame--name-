
using UnityEngine;

public class Enemy_Sideways : MonoBehaviour
{
    [SerializeField]private float movementDisstant;
    [SerializeField] private float speed;
    [SerializeField] private float damange;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDanmage(damange);
        }
    }
}
