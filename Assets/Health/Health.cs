﻿
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent< Animator > ();

    }

    public void TakeDanmage(float _damage)
    {

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);


        if (currentHealth > 0)
        {
            anim.SetTrigger("Hurt");

        }
        else
        {
            anim.SetTrigger("die");
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDanmage(1);

    }
}
