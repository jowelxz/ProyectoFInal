using UnityEngine;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null && jugador.puntos >= 100)
            {
                FindFirstObjectByType<GameManager>().MostrarGanaste();
            }
            else
            {
                Debug.Log("Necesitas 100 puntos para llegar a Isabella");
            }
        }
    }
}