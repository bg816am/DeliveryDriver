using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float steerSpeed = 20;
    [SerializeField] float driveSpeed = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
