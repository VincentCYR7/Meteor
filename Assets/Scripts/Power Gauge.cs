using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Script : MonoBehaviour
{
    float Power = 0;
    public Slider healthBar;
    bool Maxgauge;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Power;
        if (Power >= 150)
        {
            Maxgauge = true;
        }
        else if (Power <= 0)
        {
            Maxgauge = false;
        }
        if (Input.GetMouseButton(0))
        {
            if (Maxgauge)
            {
                Power -= 1;
            }
            if (Maxgauge == false)
            { 
                Power += 1; 
            }
        }
    }
}
