using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Attribute we use to determine what buttons should open the door
    public int doorID;

    private bool doorOpened;


    private void Start()
    {
        // Here we make the TriggerMethod subscribe to the OnButtonPressed event
        GameEvents.Instance.OnButtonPressed += TriggerDoor;
    }

    // Function that opens and closes the door depending on the door's state
    void TriggerDoor(int triggerID)
    {
        // Here, we compare the door ID to the ID of the trigger it received from the event
        if (triggerID == doorID)
        {
            if (!doorOpened)
            {
                OpenDoor();
            }
            else
            {
                CloseDoor();
            }
        }
    }

    // Function that moves the door upwards
    private void OpenDoor()
    {
        transform.position += Vector3.up * 3;
        doorOpened = true;
        Debug.Log("Door " +  doorID + " was opened.");
    }

    // Function that moves the door downwards
    private void CloseDoor()
    {
        transform.position -= Vector3.up * 3;
        doorOpened = false;
        Debug.Log("Door " + doorID + " was closed.");
    }

}
