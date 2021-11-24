using UnityEngine;

public class Collide : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other) 
  {
      Debug.Log("Oops!");
  }

  private void OnTriggerEnter2D(Collider2D other) 
  {
      Debug.Log("I'm feeling triggered");
  }
}
