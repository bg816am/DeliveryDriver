using UnityEngine;

public class Deliver : MonoBehaviour
{

  [SerializeField] float packageDelay = 1f;
  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);


// Create variable to grab SpriteRenderer
  SpriteRenderer spriteRenderer;
  bool hasPackage = false;

  void Start() 
  {
    // variable is now assigned to the SpriteRenderer
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  void OnCollisionEnter2D(Collision2D other) 
  {
      
  }

  void OnTriggerEnter2D(Collider2D other) 
  {
      if (other.tag == "Package" && !hasPackage)
      {
        hasPackage = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, packageDelay);
        
      }
      if (other.tag == "Customer" && hasPackage)
      {
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
        
      }
  }
}
