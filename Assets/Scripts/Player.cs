﻿using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite _neutral;
    public Sprite _attackLeft;
    public Sprite _attackRight;
    public Sprite _pPose;
    public Sprite _pPoseBlack;
    public Sprite _transitionBlur;
    
    public AudioSource _attackVOalt;
    public AudioSource _attackVOalt2;
    public AudioSource _charging_VO;
    public AudioSource _charging_sfx;

    private SpriteRenderer _playerSpriteRenderer;

    private const int BLUR_FRAME_DURATION = 10;

    // Start is called before the first frame update
    void Start()
    {
        _playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private int currentBlurStep = 0;

    // Update is called once per frame
    void Update()
    {
        if (_playerSpriteRenderer.sprite.Equals(_transitionBlur) 
            && currentBlurStep >= BLUR_FRAME_DURATION)
        {
            SetSpriteFromKey();

            currentBlurStep = 0;
        }
        else if (_playerSpriteRenderer.sprite.Equals(_transitionBlur))
        {
            currentBlurStep++;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)
            || Input.GetKeyDown(KeyCode.LeftArrow)
            || Input.GetKeyDown(KeyCode.Space))
        {
            _playerSpriteRenderer.sprite = _transitionBlur;
        }
        else if (!Input.GetKey(KeyCode.RightArrow)
            && !Input.GetKey(KeyCode.LeftArrow)
            && !Input.GetKey(KeyCode.Space))
        {
            _playerSpriteRenderer.sprite = _neutral;
            _charging_sfx.Stop();
        }         
    }

    private void SetSpriteFromKey()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _playerSpriteRenderer.sprite = _attackRight;
            _attackVOalt.Play();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerSpriteRenderer.sprite = _attackLeft;
            _attackVOalt2.Play();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _playerSpriteRenderer.sprite = _pPose;
            _charging_VO.Play();
            _charging_sfx.Play();
        }
    }
}
