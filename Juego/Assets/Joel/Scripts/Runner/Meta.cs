using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject panelFaltanPuntos;

    public void CerrarMensaje()
    {
        panelFaltanPuntos.SetActive(false);
    }

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
                panelFaltanPuntos.SetActive(true);
            }
        }
    }
}