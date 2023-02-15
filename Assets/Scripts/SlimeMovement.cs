using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;

    private Rigidbody2D _playerRigidbody;

    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.Log("Player is missing a Rigidbody2D component");
        }
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        Debug.Log("IsGrounded:" + IsGrounded());
        if (Input.GetButton("Jump") && IsGrounded())
            Jump();

    }

    private void MovePlayer()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);
    }
    private void Jump() => _playerRigidbody.velocity = new Vector2(0, jumpPower);

    private bool IsGrounded()
    {
        var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 1.0f);
        //Debug.Log("groundCheck:" + groundCheck);
        //Debug.Log(groundCheck.collider.CompareTag)
        //Debug.Log("CompareTag :" + groundCheck.collider.CompareTag("floor"));
        return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    }

}
