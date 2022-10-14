using UnityEngine;

public class MeleeController : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.Play("Punch 1");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.Play("Punch 2");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.Play("Punch 3");
        }
    }
}
