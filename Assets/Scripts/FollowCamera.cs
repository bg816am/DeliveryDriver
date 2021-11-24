using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, -10);
    [SerializeField] GameObject ObjectToFollow;
    // Camera position = Car position
    void LateUpdate()
    {
       transform.position = ObjectToFollow.transform.position + offset;
    }
}
