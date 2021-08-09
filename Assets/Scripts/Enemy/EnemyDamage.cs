
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]private float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.tag == "player")
            
    }

}
