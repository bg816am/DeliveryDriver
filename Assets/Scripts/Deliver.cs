using UnityEngine;

public class Deliver : MonoBehaviour
{
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
      }
      if (other.tag == "Customer" && hasPackage)
      {
        Debug.Log("Package Delivered");
        hasPackage = false;
        
      }
  }
}
