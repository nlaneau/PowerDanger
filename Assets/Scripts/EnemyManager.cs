using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyManager : MonoBehaviour
    {
        public List<GameObject> _prefabs;

        private List<GameObject> CurrentEnemies = new List<GameObject>();
        private System.Random _randomNumberGenerator = new System.Random();

        private readonly Vector3 LEFT_SPAWN = new Vector3(-30, 0);
        private readonly Vector3 RIGHT_SPAWN = new Vector3(30, 0);
        private const int MAX_ENEMY_COUNT = 20;
        private const int FRAME_SPAWN_FREQUENCY = 100;

        private int FrameCount = 0;

        private void Update()
        {
            // Keeps track of active enemy sprites

            if (FrameCount % FRAME_SPAWN_FREQUENCY == 0)
            {
                // Spawns enemies
                if (CurrentEnemies.Count < MAX_ENEMY_COUNT)
                    SpawnEnemy();
            }

            FrameCount++;
        }

        /// <summary>
        /// Spawns a randomly selected injected prefab on a random side (left or right).
        /// </summary>
        private void SpawnEnemy()
        {
            var randomSprite = _randomNumberGenerator.Next(0, _prefabs.Count);

            var sprite = Instantiate(_prefabs[randomSprite]);

            var randomSide = _randomNumberGenerator.Next(0, 2);
            switch (randomSide)
            {
                case 0:
                    sprite.transform.position = LEFT_SPAWN;
                    break;
                case 1:
                    sprite.transform.Rotate(0, 180, 0, Space.Self);
                    sprite.transform.position = RIGHT_SPAWN; 
                    break;
            }

            CurrentEnemies.Add(sprite);
        }
    }
}