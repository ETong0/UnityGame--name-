
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;

    }

    public void TakeDanmage(float _damage)
    {

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);


        if (currentHealth > 0)
        {
            //Player Hurt
        }
        else
        {
            //Player dead
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDanmage(1);

    }
}
