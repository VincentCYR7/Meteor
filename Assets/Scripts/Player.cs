using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject gun;
    public int rotateLimit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (rotateLimit < 20)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Quaternion tempR = gun.transform.rotation;
                gun.transform.Rotate(tempR.x, tempR.y, tempR.z + 2);
                rotateLimit++;
            }
        }
        if(rotateLimit > -10)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Quaternion tempR = gun.transform.rotation;

                gun.transform.Rotate(tempR.x, tempR.y, tempR.z - 2);
                rotateLimit--;
            }
        }
        
       
    }
}
