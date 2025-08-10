using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 playerDirection;
    public float gravity = -9.8f;
    public float flapStrenght = 5f;

    private void Update()
    {
        //this will check for either a press of the spacebar or a click of the left mouse button
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            /*this section will move the player upwards based on the set value of the game engine
             multiplied by the set value of the flapStrenght variable*/
            playerDirection = Vector3.up * flapStrenght;
        }
        //this will check for touch input on mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                playerDirection = Vector3.up * flapStrenght;
            }
        }
        /*this will make the game frame rate independant 
         so as not to cause issues with lower powered systems*/
        playerDirection.y += gravity * Time.deltaTime;
        transform.position += playerDirection * Time.deltaTime;
    }
}
