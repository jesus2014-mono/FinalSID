using UnityEngine;

public class CycleIdles : MonoBehaviour
{
    private Animator animator;
    private int currentIdle = 0; // 0=Idle1, 1=Idle2, 2=Idle3

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown() // Requiere Collider en el personaje
    {
        currentIdle = (currentIdle + 1) % 3; // Cicla entre 0, 1, 2
        animator.SetInteger("IdleState", currentIdle);
    }
}