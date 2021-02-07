using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Slider _powerBar;


    // Start is called before the first frame update
    void Start()
    {
        _powerBar = GetComponent<Slider>();
        _powerBar.value = _powerBar.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPower(int level)
    {
        _powerBar.value = level;
    }
}