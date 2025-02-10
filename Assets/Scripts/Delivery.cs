using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] public float destroyDelay = 0.5f;
    [SerializeField] public Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] public Color32 noPackageColor = new Color32(1, 1, 1, 1);

    private SpriteRenderer spriteRenderer;

    bool hasPackage;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}