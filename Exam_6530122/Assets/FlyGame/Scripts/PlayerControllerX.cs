using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f; // Added default value
    public float rotationSpeed = 50f; // Added default value
    private float verticalInput; // Made private since it's only used here

    void Update() // Changed from FixedUpdate to Update
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate (changed from back to forward)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt the plane up/down based on up/down arrow keys
        // Added verticalInput to actually use the player input
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}