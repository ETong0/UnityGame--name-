
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
                StartCoroutine(ActiveFireTrap());
            }
            if (active)
                collision.GetComponent<Health>().TakeDanmage(damage);
        }

    }

    private IEnumerator ActiveFireTrap()
    {
        triggered = true;
        anim.SetBool("triggered", true);
        yield return new WaitForSeconds(activationDelay);
        active = true;
        anim.SetBool("triggered", false);
        anim.SetBool("activated", true);


        yield return new WaitForSeconds(activTime);
        active = false;
        triggered = false;
        anim.SetBool("activated", false);
    }

}
