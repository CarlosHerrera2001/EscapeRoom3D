
using UnityEngine;

public class GeneradorLlaves : MonoBehaviour
{
    public GameObject llave;
    public Transform jugador;
    public int cantidad = 10;

    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            CrearLlave();
        }
    }

    public void CrearLlave()
    {
        Vector3 posicion = new Vector3(
            Random.Range(-8f, 8f),
            0.5f,
            Random.Range(-8f, 8f)
        );

        GameObject nueva = Instantiate(llave, posicion, Quaternion.identity);
        nueva.GetComponent<ObjetoColeccionable>().Preparar(this);
    }
}
