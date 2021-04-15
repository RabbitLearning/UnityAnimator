using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator LukeAnim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
			//it`s useful for an unreturnable state
            LukeAnim.SetTrigger("RunTrigger");
			
			//it`s useful for floating stats such as walking
            //LukeAnim.SetFloat("Speed",1);
        }
        /*
		
        else if (Input.GetKeyUp(KeyCode.W))
        {
            LukeAnim.SetFloat("Speed",0);
        }
        */
    }
}
