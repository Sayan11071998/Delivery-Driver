using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] public float steerSpeed = 0.1f;
    [SerializeField] public float moveSpeed = 0.01f;
    [SerializeField] public float slowSpeed = 15f;
    [SerializeField] public float boostSpeed = 30f;

    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
    }
}