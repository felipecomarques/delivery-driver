using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    [SerializeField] float delay = 0.5f;
    [SerializeField] Color32 hasPackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackagecolor = new Color32(1, 1, 1, 1);

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You collided with something!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackagecolor;
            Destroy(collision.gameObject, delay);
        }

        if (collision.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
            spriteRenderer.color = noPackagecolor;
        }

    }
}
