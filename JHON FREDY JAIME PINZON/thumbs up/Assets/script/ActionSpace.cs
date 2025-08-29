using UnityEngine;

public class action_space : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Buscar el componente Animator en el objeto padre
        animator = GetComponentInParent<Animator>();
        if (animator == null)
        {
            Debug.LogError("No se encontró el componente Animator en el objeto padre de " + gameObject.name);
            enabled = false; // Desactiva el script para evitar más errores
            return;
        }
    }

    void Update()
    {
        // Solo ejecutar si el Animator está presente
        if (animator != null && Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("UpDownTrigger");
        }
    }
}