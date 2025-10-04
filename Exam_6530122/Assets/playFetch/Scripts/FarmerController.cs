using UnityEngine;

public class FarmerController : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Move forward and backward (W/S or Up/Down)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }
}
