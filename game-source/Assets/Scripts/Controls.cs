using UnityEngine;

/**
 * Creates a class that is used to handle character controls
 */
public class Controls
{
    private float speed = 0.2f;
   public void HandleMovement(Transform character)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            character.transform.Translate(0.0f, speed, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            character.transform.Translate(0f, -speed, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            character.transform.Translate(-speed, 0f, 0f);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            character.transform.Translate(speed, 0f, 0f);
        }
    }
}
