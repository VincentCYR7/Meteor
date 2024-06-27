using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Script : MonoBehaviour
{
    float HP = 0;
    public Slider healthBar;
    bool Maxgauge;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = HP;
        if (HP >= 150)
        {
            Maxgauge = true;

        }
        else if (HP <= 0)
        {
            Maxgauge = false;
        }
        if (Input.GetMouseButton(0))
        {
            if (Maxgauge)
            {
                HP -= 1;
            }
            if (Maxgauge == false)
            { 
                HP += 1; 
            }
        }
    }
}
