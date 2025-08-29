using UnityEngine;
using UnityEngine.InputSystem; // Nuevo Input System

public class start : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator != null)
            Debug.Log("✅ Animator encontrado");
        else
            Debug.LogError("❌ No se encontró Animator en este GameObject");
    }

    void Update()
    {
        // Cuando presione la tecla "X"
        if (Keyboard.current != null && Keyboard.current.xKey.wasPressedThisFrame)
        {
            animator.SetInteger("a", 0); // Cambia el parámetro "a" en el Animator
            Debug.Log("⏺ Tecla X presionada → parámetro 'a' = 0");
        }
    }
}
