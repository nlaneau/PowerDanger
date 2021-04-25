using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyManager : MonoBehaviour
    {
        public List<GameObject> _enemyPrefabs;

        private readonly List<GameObject> CurrentEnemies = new List<GameObject>();

        private readonly Vector3 LEFT_SPAWN = new Vector3(-30, 0);
        private readonly Vector3 RIGHT_SPAWN = new Vector3(30, 0);
        private const int MAX_ENEMY_COUNT = 50;
        private const int FRAME_SPAWN_FREQUENCY = 150;

        private int FrameCount = 0;

        private void Update()
        {
            // Keeps track of active enemy sprites

            if (FrameCount % FRAME_SPAWN_FREQUENCY == 0)
            {
                // Spawns enemies
                if (CurrentEnemies.Count < MAX_ENEMY_COUNT)
                    SpawnEnemy();

                FrameCount = 0;
            }

            FrameCount++;
        }

        /// <summary>
        /// Spawns a randomly selected injected prefab on a random side (left or right).
        /// </summary>
        private void SpawnEnemy()
        {
            var randomSprite = Random.Range(0, _enemyPrefabs.Count);

            var sprite = Instantiate(_enemyPrefabs[randomSprite]);

            var randomSide = Random.Range(0, 2);
            switch (randomSide)
            {
                case 0:
                    sprite.transform.position = LEFT_SPAWN;
                    break;
                case 1:
                    sprite.transform.Rotate(0, -180, 0, Space.Self);
                    sprite.transform.position = RIGHT_SPAWN; 
                    break;
            }

            CurrentEnemies.Add(sprite);
        }
    }
}