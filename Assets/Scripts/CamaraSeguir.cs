using UnityEngine;
public class CamaraSeguir : MonoBehaviour
{
    public Transform objetivo;
    public float distancia = 5f;
    public float altura = 2f;
    public float sensibilidad = 3f;
    private float giro = 0f;
    private float inclinacion = 15f;
    void LateUpdate()
    {
        if (objetivo == null) return;

        giro += Input.GetAxis("Mouse X") * sensibilidad;
        inclinacion -= Input.GetAxis("Mouse Y") * sensibilidad;
        inclinacion = Mathf.Clamp(inclinacion, -10f, 60f);

        Quaternion rotacion = Quaternion.Euler(inclinacion, giro, 0f);

        Vector3 posicion = objetivo.position + Vector3.up * altura;
        transform.position = posicion - rotacion * Vector3.forward * distancia;
        transform.rotation = rotacion;
    }
}
