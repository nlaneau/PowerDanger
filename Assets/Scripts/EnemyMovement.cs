using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float MOVE_SPEED = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // Left or Right side (varying heights?)

        // Flip sprite to be properly oriented with attack direction
    }

    // Update is called once per frame
    void Update()
    {
        // Check if player striked
            // Dead animation

        // Check if enemy strikes player
            // Puff/disappear animation

        MoveTowardsPlayer();
    }

    /// <summary>
    /// Changes the position of the GameObject to be closer to the
    /// center at a rate of <see cref="MOVE_SPEED"/> per frame.
    /// </summary>
    private void MoveTowardsPlayer()
    {
        var playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, MOVE_SPEED);
        /*var currentX = transform.position.x;
        var currentY = transform.position.y;

        float newXPos;
        if (currentX < playerObj.transform.position.x)
            newXPos = currentX + MOVE_SPEED;
        else
            newXPos = currentX - MOVE_SPEED;
        
        transform.position = new Vector3(newXPos, currentY);*/
        // Calc distance to player position

        // Add constant * distance to enemy position
    }
}
