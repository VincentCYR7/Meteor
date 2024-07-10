using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{

    public int shield;
    public bool live;
    public WinLose WinLoseCond;
    // Start is called before the first frame update
    void Start()
    {
        shield = 2;
        live = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!live)
        {
            WinLoseCond.LoseLevel();
        }
    }
}
