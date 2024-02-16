using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellPickup : Clickable
{
    protected override void GotClicked()
    {
        gm.UpdateScore(1);
        Destroy(gameObject);
    }
}
