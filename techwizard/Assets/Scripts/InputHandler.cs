using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private PlayerController inputActions;
    private Rigidbody2D rb;

    [SerializeField] private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        inputActions = new PlayerController();
        inputActions.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = inputActions.Player.Movement.ReadValue<Vector2>();
        rb.velocity = movement.normalized * velocity * Time.deltaTime;
    }
}
