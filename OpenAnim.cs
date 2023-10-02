using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnim : MonoBehaviour
{
    public Animator animator;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("InTrigger", true);
            animator.SetBool("out", false);

        } 
            
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("out", true);
            animator.SetBool("InTrigger", false);
        }

    }
}
