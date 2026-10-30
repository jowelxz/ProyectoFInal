using UnityEngine;

public class TrampaMortaMenos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats vidaJugador =
                collision.gameObject.GetComponent<PlayerStats>();

            if (vidaJugador != null)
            {
                if (vidaJugador.tieneEscudo)
                {
                    vidaJugador.tieneEscudo = false;
                    Debug.Log("¡El escudo bloqueó el golpe!");
                }
                else
                {
                    vidaJugador.RestarVida(30);

                    if (vidaJugador.vidaActual <= 0)
                    {
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
    }
}