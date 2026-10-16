using UnityEngine;
public class ObjetoColeccionable : MonoBehaviour
{
    private GeneradorLlaves generador;
    public void Preparar(GeneradorLlaves nuevoGenerador)
    {
        generador = nuevoGenerador;
    }
    void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("Player"))
        {
            generador.CrearLlave();
            Destroy(gameObject);
        }
    }
}
