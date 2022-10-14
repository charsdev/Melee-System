using UnityEngine;

public class HurtBox : MonoBehaviour
{
    public Health Health;
    public Transform Owner;
    public BodyParts BodyPart;
    public BlinkColor blinkColor;

    public void Awake()
    {
    }

    public void GetHurt(int damage)
    {
        blinkColor.Blink();
        Health.HandleDamage(damage, BodyPart);
    }
}
