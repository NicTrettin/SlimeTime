using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 15;
    private Rigidbody2D rb;
    private float y;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(x, y);
        Run(direction);

    }
    public void Run(Vector2 dir)
    {
        rb.AddForce(new Vector2(dir.x * speed, 0));
    }
}
