using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Attribute we made to determine what objects the button will trigger
    public int buttonID;


    // Code that triggers when the player object touches the button
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // We trigger the event here through the GameEvent singleton object
            GameEvents.Instance.ButtonPressed(buttonID);
        }
            
    }
}
