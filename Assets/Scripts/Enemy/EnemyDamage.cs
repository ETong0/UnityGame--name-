
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]private float damage;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
            collision.GetComponent<Health>().TakeDanmage(damage);
    }
   
}
