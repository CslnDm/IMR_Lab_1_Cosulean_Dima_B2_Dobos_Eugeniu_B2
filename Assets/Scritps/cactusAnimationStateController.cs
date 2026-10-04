using UnityEngine;

public class cactusAnimationStateController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        if (animator == null)
            animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other){
        animator.SetBool("uncomfortableDistance", true);
    }

    private void OnTriggerExit(Collider other){
        animator.SetBool("uncomfortableDistance", false);
    }
}
