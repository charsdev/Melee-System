using System.Collections.Generic;
using UnityEngine;

public enum BodyParts
{
    LEFT_HAND,
    RIGHT_HAND,
    LEFT_FOOT,
    HEAD,
    BODY
}

public class HitboxController : MonoBehaviour
{
    public Collider LeftHand, RightHand, LeftFoot, RightFoot;
    public Dictionary<int, Collider> enumToHitbox = new Dictionary<int, Collider>();

    public void Start()
    {
        enumToHitbox.Add((int)BodyParts.LEFT_HAND, LeftHand);
        enumToHitbox.Add((int)BodyParts.RIGHT_HAND, RightHand);
        enumToHitbox.Add((int)BodyParts.LEFT_FOOT, LeftFoot);
    }

    public void SetHitbox(BodyParts bodyParts)
    {
        enumToHitbox.TryGetValue((int)bodyParts, out Collider hit);
        hit.gameObject.SetActive(!hit.gameObject.activeInHierarchy);
    }

}
