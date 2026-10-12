using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 distancia = new Vector3(0f, 4f, -8f);
    public float suavidad = 5f;

    void LateUpdate()
    {
        if (objetivo == null) return;

        Vector3 posicionDeseada = objetivo.TransformPoint(distancia);
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
        transform.LookAt(objetivo.position + Vector3.up * 1.5f);
    }
}