using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class StrikeCollider : MonoBehaviour
    {
        private SpriteRenderer SpriteRenderer;
        private BoxCollider2D BoxCollider;

        // Start is called before the first frame update
        void Start()
        {
            SpriteRenderer = GetComponentInParent<SpriteRenderer>();
            BoxCollider = GetComponent<BoxCollider2D>();
        }

        void Update()
        {
            // Determine if any should be active, depending on the current Player pose
            if (SpriteRenderer.sprite.name == "pman_atk_L" && CompareTag("LeftStrikeCollider"))
            {
                BoxCollider.enabled = true;
                return;
            }
            else if (SpriteRenderer.sprite.name == "pman_atk_R" && CompareTag("RightStrikeCollider"))
            {
                BoxCollider.enabled = true;
                return;
            }

            BoxCollider.enabled = false;
        }
    }    
}
