using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");

        rigidbody2d.velocity = new Vector2(dirX * 7f, rigidbody2d.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, 14f);
        }
    }
}
