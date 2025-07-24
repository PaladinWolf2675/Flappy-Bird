using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 playerDirection;

    public float gravity = -9.8f;

    public float strength = 5f;
    

    private void Update()
    {
        // This will check for key presses on a keyboard
        if (Input.GetKeyDown(KeyCode.Space)  || Input.GetMouseButtonDown(0))
        {
            playerDirection = Vector3.up * strength;
        }

        // This will check for touch input on mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
        }
    }
}
