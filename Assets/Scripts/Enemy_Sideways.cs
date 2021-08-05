
using UnityEngine;

public class Enemy_Sideways : MonoBehaviour
{

    [SerializeField] private float damange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDanmage(damange);
        }
    }
}
