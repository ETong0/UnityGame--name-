using UnityEngine;

public class healthCollectable : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private Health playerHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (playerHealth.currentHealth < playerHealth.startingHealth)
            {
                collision.GetComponent<Health>().addHealth(healthValue);
                gameObject.SetActive(false);
            }
           
        }
    }
}
