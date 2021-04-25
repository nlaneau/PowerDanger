using UnityEngine;

namespace Assets.Scripts
{
    class StrikeCollider : MonoBehaviour
    {
        private SpriteRenderer _playerSpriteRenderer;
        private BoxCollider2D _hitBox;

        // Start is called before the first frame update
        void Start()
        {
            _playerSpriteRenderer = GetComponentInParent<SpriteRenderer>();
            _hitBox = GetComponent<BoxCollider2D>();
        }

        void Update()
        {
            // Determine if any should be active, depending on the current Player pose
            if (_playerSpriteRenderer.sprite.name == "pman_atk_L" 
                && CompareTag(Constants.LeftStrikeCollider))
            {
                _hitBox.enabled = true;
                return;
            }
            else if (_playerSpriteRenderer.sprite.name == "pman_atk_R" 
                && CompareTag(Constants.RightStrikeCollider))
            {
                _hitBox.enabled = true;
                return;
            }

            _hitBox.enabled = false;
        }
    }    
}
