using UnityEngine;

public class Act : StateMachineBehaviour
{
    // Cuando entra en la animación
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Animación iniciada");
    }

    // Cuando la animación termina
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Animación terminada");

        // 👇 Evita que se repita automáticamente
        animator.ResetTrigger("PlayOnce"); 
        // (Usa el nombre real del Trigger o parámetro que activa tu animación)
    }
}
