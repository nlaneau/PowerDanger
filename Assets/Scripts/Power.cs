using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Power : MonoBehaviour
    {
        public int _currentPower = 0;
        public int _maxPower = 100;

        public PowerBar _powerBar;

        private void Start()
        {
            _currentPower = _maxPower;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GainPower(5);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)
                || Input.GetKeyDown(KeyCode.RightArrow))
            {
                LosePower(5);
            }
        }

        public void GainPower(int powerIncrease)
        {
            _currentPower = Math.Min(100, _currentPower + powerIncrease);

            _powerBar.SetPower(_currentPower);
        }

        public void LosePower(int powerDecrease)
        {
            _currentPower = Math.Max(0, _currentPower - powerDecrease);

            _powerBar.SetPower(_currentPower);
        }
    }
}
