using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Clickable : MonoBehaviour
{
    protected GameManager gm;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if(GameObject.Find("GameManager") != null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }

  protected virtual void GotClicked()
    {
        Debug.Log($"{name} has been clicked");
    }

    private void OnMouseDown()
    {
        GotClicked();
    }
}
