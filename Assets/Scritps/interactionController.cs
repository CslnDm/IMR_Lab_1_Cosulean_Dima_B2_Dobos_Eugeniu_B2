using UnityEngine;

public class interactionController
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other){
        animator.SetBool("uncomfortableDistance", true);
    }

    private void OnTriggerExit(Collider other){
        animator.SetBool("uncomfortableDistance", false);
    }
}
