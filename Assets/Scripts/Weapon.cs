using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable_tilemap
{
    //protected Vector3 moveDelta;
    //Vector2 movement;
    //public float moveSpeed = 5f;

    // Damage struct
    public int damagePoint = 1;
    public float pushForce = 2.0f;

    //Swing
    private Animator anim;
    private float cooldown = 0.3f;
    private float lastSwing;

    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    protected override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastSwing > cooldown)
            {
                lastSwing = Time.time;
                Swing();
            }
        }
        //flipSprite();
    }

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.tag == "Fighter")
        {
            if (coll.name == "Player")
                return;

            // Create a new damage object, then we'll send it to the fighter we've hit
            Damage dmg = new Damage
            {
                damageAmount = damagePoint,
                origin = transform.position,
                pushForce = pushForce
            };

            coll.SendMessage("RecieveDamage", dmg);
        }
    }

    private void Swing()
    {
        SoundManager.PlaySound("scissor_swing");
        anim.SetTrigger("Swing");
    }

    //private void flipSprite()
    //{
    //    movement.x = Input.GetAxisRaw("Horizontal");
    //    movement.y = Input.GetAxisRaw("Vertical");
    //    moveDelta = new Vector3(movement.x * moveSpeed, movement.y * moveSpeed, 0);

    //    //Flipes sprite
    //    if (moveDelta.x > 0)
    //        transform.localScale = new Vector3(1, 1, 1);
    //    else if (moveDelta.x < 0)
    //        transform.localScale = new Vector3(-1, -1, 1);
    //}
}
