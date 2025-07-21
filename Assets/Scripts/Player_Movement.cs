using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D PlayerRB;
    private Vector3 change;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change != Vector3.zero)
        {
            Move();
        }
    }

    void Move()
    {
        PlayerRB.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }
}
