using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyColliders : MonoBehaviour
    {
        public Power _power;

        private const int HURT_POWER_LEVEL = 25;

        private void Start()
        {
            _power = GameObject.FindGameObjectWithTag(Constants.Player).GetComponent<Power>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(Constants.LeftStrikeCollider) 
                || collision.CompareTag(Constants.RightStrikeCollider))
            {
                // Enemy dies
                Destroy(transform.gameObject);
            }
            else if (collision.CompareTag(Constants.PlayerMainCollider))
            {
                // Player gets hurt
                Destroy(transform.gameObject);
                _power.LosePower(HURT_POWER_LEVEL);
            }
            else
            {
                // Something went wrong..
                Console.WriteLine("Unexpected collision");
            }
        }
    }
}
