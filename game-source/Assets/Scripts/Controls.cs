using UnityEngine;

/**
 * Creates a class that is used to handle character controls
 */
public class Controls
{
   public void HandleMovement(Transform character)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            character.transform.Translate(0.0f, 1f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            character.transform.Translate(0f, -1f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            character.transform.Translate(-1f, 0f, 0f);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            character.transform.Translate(1f, 0f, 0f);
        }
    }
}
