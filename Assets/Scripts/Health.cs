using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int CurrentLife;
    public int MaxLife = 100;
    public Animator animator;

    private void Start()
    {
        CurrentLife = MaxLife;
        animator = GetComponent<Animator>();
    }

    private void Update() { }

    public void HandleDamage(int value, BodyParts bodyParts)
    {
        CurrentLife -= value;

        if (bodyParts == BodyParts.HEAD)
        {
            animator.SetTrigger("HeadHit");
        }
        else
        {
            animator.SetTrigger("Hit");
        }

    }
}
