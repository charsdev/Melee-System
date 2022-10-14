using System.Collections;
using UnityEngine;

public class BlinkColor : MonoBehaviour
{
    public Renderer Renderer;
    public Color NewColor;
    private Color OriginalColor;

    private void Awake()
    {
        Renderer = GetComponent<Renderer>();
        OriginalColor = Renderer.material.color;
    }

    public void Blink() => StartCoroutine(BlinkCoroutine());

    public IEnumerator BlinkCoroutine()
    {
        Renderer.material.color = NewColor;
        yield return new WaitForSeconds(0.1f);
        Renderer.material.color = OriginalColor;
    }
}
