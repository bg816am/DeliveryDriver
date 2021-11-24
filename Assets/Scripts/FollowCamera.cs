using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ObjectToFollow;
    // Camera position = Car position
    void LateUpdate()
    {
       transform.position = ObjectToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
