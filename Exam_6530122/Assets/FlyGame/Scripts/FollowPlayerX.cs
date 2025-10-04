using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane; // This should be assigned in Inspector
    private Vector3 offset = new Vector3(30, 0, 10); // Added offset initialization

    void Start()
    {
        // Optional: Automatically find the plane if not assigned
        if (plane == null)
        {
            plane = GameObject.FindGameObjectWithTag("Player");
        }
    }

    void LateUpdate() // Changed to LateUpdate for smoother camera movement
    {
        if (plane != null) // Safety check
        {
            transform.position = plane.transform.position + offset;
        }
    }
}