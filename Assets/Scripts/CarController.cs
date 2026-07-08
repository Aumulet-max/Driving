using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    InputAction moveAction;
    [SerializeField]
    float speed = 10f;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Player/Move");

    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(0, 0, moveInput.y);
        Vector3 rotateDirection = new Vector3(0, moveInput.x, 0);
        transform.Translate(moveDirection * speed * Time.deltaTime);
        transform.Rotate(rotateDirection * speed * Time.deltaTime);

       
    }
}