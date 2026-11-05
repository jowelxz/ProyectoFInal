using UnityEngine;

public class Donas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                jugador.SumarPuntos(20);
                Destroy(gameObject);
            }
        }
    }
}