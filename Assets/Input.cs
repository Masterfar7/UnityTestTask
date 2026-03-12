using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public float speed = 5f;
    private InputSystem_Actions controls;

    private void Awake()
    {
        controls = new InputSystem_Actions();
        controls.Player.Enable();
    }

    private void Update()
    {
        Vector2 move = controls.Player.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            HitsManager.hits++;
            Debug.Log("Попадание");
        }
    }
}
