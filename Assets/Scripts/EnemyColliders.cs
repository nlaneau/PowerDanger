using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyColliders : MonoBehaviour
    {
        private void Start()
        {
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
            }
            else
            {
                // Something went wrong..
            }
        }
    }
}
