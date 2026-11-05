using UnityEngine;

public class Escudos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador =
                collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                jugador.tieneEscudo = true;
                Destroy(gameObject);
            }
        }
    }
}