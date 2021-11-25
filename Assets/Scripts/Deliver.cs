using UnityEngine;

public class Deliver : MonoBehaviour
{

  [SerializeField] float packageDelay = 1f;
  bool hasPackage = false;
  private void OnCollisionEnter2D(Collision2D other) 
  {
      Debug.Log("Oops!");
  }

  private void OnTriggerEnter2D(Collider2D other) 
  {
      if (other.tag == "Package")
      {
        Debug.Log("Package Picked");
        hasPackage = true;
        Destroy(other.gameObject, packageDelay);
      }
      if (other.tag == "Customer" && hasPackage)
      {
        Debug.Log("Package Delivered");
        hasPackage = false;
        
      }
  }
}
