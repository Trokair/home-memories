using UnityEngine;

public class Controls
{
   public void HandleMovement(Transform character)
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
           Debug.Log("moving something");
        }
    }
}
