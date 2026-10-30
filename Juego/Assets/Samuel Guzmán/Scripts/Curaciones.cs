using UnityEngine;

public class Curaciones : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats vidaJugador =
                collision.GetComponent<PlayerStats>();

            if (vidaJugador != null)
            {
                vidaJugador.SumarVida(20);
                Destroy(gameObject);
            }
        }
    }
}