using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int doorID;

    public bool triggerDoor;
    private bool doorOpened;

    void Update()
    {
        if (triggerDoor)
        {
            if (!doorOpened)
            {
                OpenDoor();
            }
            else
            {
                CloseDoor();
            }
            triggerDoor = false;
        }
    }

    private void OpenDoor()
    {
        transform.position += Vector3.up * 3;
        doorOpened = true;
        Debug.Log("Door " +  doorID + " was opened.");
    }

    private void CloseDoor()
    {
        transform.position -= Vector3.up * 3;
        doorOpened = false;
        Debug.Log("Door " + doorID + " was closed.");
    }

}
