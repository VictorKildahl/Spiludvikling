using UnityEngine;

public class Player : Mover
{
    //public float moveSpeed = 5f;

    //private void FixedUpdate()
    //{
    //    float x = Input.GetAxisRaw("Horizontal");
    //    float y = Input.GetAxisRaw("Vertical");

    //    UpdateMotor(moveSpeed, new Vector3(x, y, 0));
    //}

    //protected override void Death()
    //{
    //    Destroy(gameObject); // when enenmy dies it is removed from map
    //    GameManager.instance.ShowText("Death", 30, Color.magenta, transform.position, Vector3.up * 40, 1.0f);
    //}

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        UpdateMotor(moveSpeed, new Vector3(movement.x, movement.y, 0));
    }

    //void FixedUpdate()
    //{
    //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    //}

    protected override void Death()
    {
        Destroy(gameObject); // when enenmy dies it is removed from map
        GameManager.instance.ShowText("Death", 50, Color.magenta, transform.position, Vector3.up * 40, 1.0f);
    }
}

