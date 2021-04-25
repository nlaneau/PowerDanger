using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float MOVE_SPEED = 0.1f;

    private GameObject _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
    }

    /// <summary>
    /// Changes the position of the GameObject to be closer to the
    /// center at a rate of <see cref="MOVE_SPEED"/> per frame.
    /// </summary>
    private void MoveTowardsPlayer()
    {
        var playerPos = _player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, MOVE_SPEED);
    }
}
