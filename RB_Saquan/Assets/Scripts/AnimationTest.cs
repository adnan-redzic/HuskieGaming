using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    // reference to the Animator component
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // get the animator component of the Game Object
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // change the animator's AnimState variable if a key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("AnimState", 1);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimState", 1);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("AnimState", 1);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("AnimState", 1);
        }

        else
        {
            animator.SetInteger("AnimState", 0);
        }
    }
}
