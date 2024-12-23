using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.direcion.x > 0)
        {
            anim.SetInteger("iTransition", 2);
        }
        else if (playerController.direcion.x < 0)
        {
            anim.SetInteger("iTransition", 1);
        }
        else
        {
            anim.SetInteger("iTransition", 0);
        }
    }


}
