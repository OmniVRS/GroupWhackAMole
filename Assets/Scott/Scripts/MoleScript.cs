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
    public GameObject collectablePrefab;

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
        if (!isClicked)
        {
            gm.UpdateScore(1);
        }

        isClicked = true;
        sr.sprite = deadMole;
        float dropChance = Random.Range(0f, 10f);

        if (dropChance > 8f)
        {
            Instantiate(collectablePrefab, transform.position, collectablePrefab.transform.rotation);
        }

        Invoke("KillIt", actualDifficulty);
    }

    void LifeTime()
    {
        if (!isClicked)
        {
            gm.UpdateLives(1);
            Destroy(gameObject);
        }
    }

    void KillIt()
    {
        Destroy(gameObject);
    }
}
