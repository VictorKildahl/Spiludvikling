
using UnityEngine;

public class Enemy : Mover
{
    // Logic

    public float moveSpeed = 10f;
    public float triggerLenght = 0.5f; // within 1 meter enemy will start to chase player
    public float chaseLenght = 5; // will chase for 5 meters
    private Transform playerTransform;
    private Vector3 startingPosition;

    protected virtual void Start()
    {
        playerTransform = GameManager.instance.player.transform;
        startingPosition = transform.position; // wherever enemy is placed on the map, that is going to be the starting position when the game starts
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(playerTransform.position, startingPosition) < chaseLenght)
        {
            if (Vector3.Distance(playerTransform.position, startingPosition) < triggerLenght) {
                UpdateMotor(moveSpeed, (playerTransform.position - transform.position).normalized); // move in the direction of the player
            }
               
        }

    }

    protected override void Death()
    {
        Destroy(gameObject); // when enenmy dies it is removed from map
        GameManager.instance.ShowText("Death", 50, Color.magenta, transform.position, Vector3.up * 40, 1.0f);
    }
}
