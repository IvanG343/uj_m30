using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Move Params")]
    [SerializeField] private float speed;

    [Header("References")]
    private PlayerInput input;
    private Rigidbody rb;

    private void Start()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if(input.IsThereTouchOnScreen())
        {
            Vector2 deltaPos = input.GetTouchDeltaPosition();
            Vector3 move = new Vector3(deltaPos.x, 0f, deltaPos.y);

            rb.AddForce(move * speed, ForceMode.Acceleration);
        }
    }
}
