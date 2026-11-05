using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject panelFaltanPuntos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                if (jugador.puntos >= 100 && jugador.tieneMoño)
                {
                    FindFirstObjectByType<GameManager>().MostrarGanaste();
                }
                else
                {
                    panelFaltanPuntos.SetActive(true);
                }
            }
        }
    }

    public void CerrarMensaje()
    {
        panelFaltanPuntos.SetActive(false);
    }
}