using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRedone : MonoBehaviour
{
    private Animator anim;
    private HashIDs hash;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void foward(float forward)
    {
        if (Input.GetKeyDown("w"))
            { 

            anim.SetFloat("Speed", 0f);

            }

        else if (Input.GetKeyUp("w"))
        {

            anim.SetFloat("Speed", 0f);

        }
    }

    void backward(float backward)
    {
        if(Input.GetKeyDown("s"))
            {



            }
    }
        

}
