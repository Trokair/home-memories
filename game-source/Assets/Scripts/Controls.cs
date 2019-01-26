using UnityEngine;

/**
 * Creates a class that is used to handle character controls
 */
public class Controls
{
    private float speed = 0.2f;
   public void HandleMovement(Transform character)
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            character.transform.Translate(speed, 0f, 0f);
            character.rotation = Quaternion.Euler(0f, -180f, 0f);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            character.transform.Translate(speed, 0f, 0f);
            character.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
