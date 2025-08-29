using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obtiene el componente Animator del objeto
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Detecta cuando se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Si tu animación está en un trigger
            animator.SetTrigger("PlayAnimation");

            // O si tu animación es un estado llamado "Jump"
            // animator.Play("Jump");
        }
    }
}
