using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private InputActions actions;
    private InputAction movementAction;

    void Awake()
    {
        actions = new InputActions();
        movementAction = actions.moving.movement;
    }

    void OnEnable()
    {
        movementAction.Enable();
    }

    void OnDisable()
    {
        movementAction.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float upDown = movementAction.ReadValue<Vector2>().y;
        float leftRight = movementAction.ReadValue<Vector2>().x;
        transform.Translate(Vector3.forward * speed * upDown * Time.deltaTime, Space.Self);
        transform.Translate(Vector3.right * speed * leftRight * Time.deltaTime, Space.Self);
    }
}
