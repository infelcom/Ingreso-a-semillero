using UnityEngine;

public class begin : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Buscar el componente Animator en el mismo GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Cuando presione la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Activa un parámetro en el Animator
            animator.SetTrigger("startAnim"); 
        }
    }
}
