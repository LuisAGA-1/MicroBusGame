using UnityEngine;
using UnityEngine.InputSystem;

public class CuboControl : MonoBehaviour
{
    public float velocidad = 5f;
    public float giro = 90f;

    void Update()
    {
        var teclado = Keyboard.current;
        if (teclado == null) return;

        float avance = 0f;
        float rotacion = 0f;

        if (teclado.wKey.isPressed) avance = 1f;
        if (teclado.sKey.isPressed) avance = -1f;
        if (teclado.dKey.isPressed) rotacion = 1f;
        if (teclado.aKey.isPressed) rotacion = -1f;

        transform.Translate(Vector3.forward * avance * velocidad * Time.deltaTime);
        transform.Rotate(0f, rotacion * giro * Time.deltaTime, 0f);
    }
}