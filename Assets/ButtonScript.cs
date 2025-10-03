using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int buttonID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Debug.Log("Button number " + buttonID + " pressed!");
    }
}
