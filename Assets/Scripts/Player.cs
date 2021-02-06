using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite _neutral;
    public Sprite _attackLeft;
    public Sprite _attackRight;
    public Sprite _pPose;
    public Sprite _pPoseBlack;
    public Sprite _transitionBlur;

    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private int i = 0;

    // Update is called once per frame
    void Update()
    {
        // Dummy test code below
        switch (i)
        {
            case 0:
                SpriteRenderer.sprite = _neutral;
                break;
            case 1:
                SpriteRenderer.sprite = _attackLeft;
                break;
            case 2:
                SpriteRenderer.sprite = _attackRight;
                break;
            case 3:
                SpriteRenderer.sprite = _pPose;
                break;
            case 4:
                SpriteRenderer.sprite = _pPoseBlack;
                break;
            case 5:
                SpriteRenderer.sprite = _transitionBlur;
                break;
        }

        i++;

        if (i > 5)
            i = 0;

        // Check button presses
            // Switch pose based on input, with blur in between
    }
}
