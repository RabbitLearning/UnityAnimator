using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator LukeAnim;

    // Start is called before the first frame update
    void Start()
    {
        LukeAnim.SetBool("Run", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
