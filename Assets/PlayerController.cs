using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput input;
    private Rigidbody rb;

    private Vector2 movDir;
    public float movSpd;

    private InputAction move;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
        move = input.actions["Move"];
    }

    void Update()
    {
        movDir = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (movDir != Vector2.zero)
        {
            rb.linearVelocity = new Vector3(movDir.x * movSpd, rb.linearVelocity.y, movDir.y * movSpd);
        }
        
    }
}
