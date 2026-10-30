using UnityEngine;

public class TrampaMortalKill : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats vidaJugador =
                collision.gameObject.GetComponent<PlayerStats>();

            if (vidaJugador != null)
            {
                vidaJugador.RestarVida(vidaJugador.vidaActual);
            };
        }

        Destroy(collision.gameObject);
    }
}
