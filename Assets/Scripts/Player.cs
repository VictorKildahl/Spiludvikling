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
    //public Animator animator;

    Vector2 movement;
    private bool isAlive = true;

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);

        if (isAlive) {
            UpdateMotor(moveSpeed, new Vector3(movement.x, movement.y, 0));
        }
    }

    //void FixedUpdate()
    //{
    //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    //}

    protected override void RecieveDamage(Damage dmg)
    {
        if (Time.time - lastImmune > immuneTime)
        {
            lastImmune = Time.time;
            hitpoint -= dmg.damageAmount;
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;

            GameManager.instance.ShowText("-" + dmg.damageAmount.ToString(), 50, Color.red, transform.position, Vector3.zero, 0.5f);
            SoundManager.PlaySound("woman_hit");

            if (hitpoint <= 0)
            {
                hitpoint = 0;
                Death();
            }
        }

        GameManager.instance.OnHitpointChange();
    }

    protected override void Death()
    {
        isAlive = false;
        Destroy(gameObject); // when enenmy dies it is removed from map
        //GameManager.instance.ShowText("Death", 50, Color.magenta, transform.position, Vector3.up * 40, 1.0f);
        GameManager.instance.deathMenuAnim.SetTrigger("Show");
    }

    public void Respawn()
    {
        hitpoint = maxHitpoint;
        isAlive = true;
        lastImmune = Time.time;
        pushDirection = Vector3.zero;
    }
}

