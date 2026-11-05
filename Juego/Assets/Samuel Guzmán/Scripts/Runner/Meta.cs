using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject panelFaltanRequisitos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats jugador = collision.GetComponent<PlayerStats>();

            if (jugador != null)
            {
                if (jugador.puntos >= 100 && jugador.tieneRamo)
                {
                    FindFirstObjectByType<GameManager>().MostrarGanaste();
                }
                else
                {
                    panelFaltanRequisitos.SetActive(true);
                }
            }
        }
    }

    public void CerrarMensaje()
    {
        panelFaltanRequisitos.SetActive(false);
    }
}