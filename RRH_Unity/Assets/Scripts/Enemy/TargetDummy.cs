using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private Color hitColor;
    [SerializeField] private float colorChangeDuration;
    private Color baseColor;


    private void Start()
    {
        baseColor = renderer.color;
    }

    [ContextMenu("Simulate Hit")]
    public void OnHit()
    {
        StopCoroutine(ChangeColor());
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        renderer.color = hitColor;

        yield return new WaitForSeconds(colorChangeDuration);

        renderer.color = baseColor;
    }
}
