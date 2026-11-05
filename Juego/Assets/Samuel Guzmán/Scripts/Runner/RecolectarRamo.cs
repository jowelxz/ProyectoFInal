using UnityEngine;

public class RecolectarRamo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                jugador.tieneRamo = true;
                Destroy(gameObject);
            }
        }
    }
}