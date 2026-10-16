using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform camara;
    private CharacterController controlador;
    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 adelante = camara.forward;
        Vector3 derecha = camara.right;

        adelante.y = 0;
        derecha.y = 0;

        adelante.Normalize();
        derecha.Normalize();

        Vector3 movimiento = adelante * vertical + derecha * horizontal;

        controlador.SimpleMove(movimiento * velocidad);
    }
}

