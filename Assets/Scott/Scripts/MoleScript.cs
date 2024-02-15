using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : Clickable
{
    private SpriteRenderer sr;
    public Sprite livingMole;
    public Sprite deadMole;
    private bool isClicked;
    public float actualDifficulty;

    protected override void Start()
    {
        base.Start();
        sr = GetComponent<SpriteRenderer>();
        actualDifficulty = 3;
        sr.sprite = livingMole;
        Invoke("LifeTime", actualDifficulty);
    }

    protected override void GotClicked()
    {
        isClicked = true;
        sr.sprite = deadMole;
        Invoke("KillIt", actualDifficulty);
    }

    void LifeTime()
    {
        if (!isClicked)
        {
            Destroy(gameObject);
        }
    }

    void KillIt()
    {
        Destroy(gameObject);
    }
}
