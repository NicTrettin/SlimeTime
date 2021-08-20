using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpPower = 5;
    private float y;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void Update()
    {
        float y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            Up(Vector2.up);
        }
    }
    public void Up(Vector2 dir)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpPower;
    }
}
