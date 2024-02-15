using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : Clickable
{
    private Animator animator;
    private bool isClicked;
    public float actualDifficulty;

    protected override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
        actualDifficulty = 3;
        Invoke("LifeTime", actualDifficulty);
    }

    protected override void GotClicked()
    {
        isClicked = true;
        animator.SetBool("isDead", true);
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
