using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public Transform Owner;
    public int Damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HurtBox"))
        {
            HurtBox hurtbox = other.GetComponent<HurtBox>();
            if (hurtbox && hurtbox?.Owner != Owner)
            {
                Debug.Log(transform.parent.name + " - " + other.name);
                hurtbox.GetHurt(Damage);
            }
        }
    }
}
