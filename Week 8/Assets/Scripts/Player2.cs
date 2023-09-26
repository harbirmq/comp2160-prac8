using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player2 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private InputActions actions;
    private InputAction movement2Action;

    void Awake()
    {
        actions = new InputActions();
        movement2Action = actions.moving.movement2;
    }

    void OnEnable()
    {
        movement2Action.Enable();
    }

    void OnDisable()
    {
        movement2Action.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float upDown = movement2Action.ReadValue<Vector2>().y;
        float leftRight = movement2Action.ReadValue<Vector2>().x;
        transform.Translate(Vector3.forward * speed * upDown * Time.deltaTime, Space.Self);
        transform.Translate(Vector3.right * speed * leftRight * Time.deltaTime, Space.Self);
    }
}
