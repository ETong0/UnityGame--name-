
using System.Collections;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    [SerializeField] private float damage;

    [Header("fire trap timer")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activTime;
    private Animator anim;
    private SpriteRenderer spritRend;

    private bool triggered;
    private bool active;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spritRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!triggered)
            {

            }
            if (active)
                collision.GetComponent<Health>().TakeDanmage(damage);
        }

    }

    private IEnumerator 
}
