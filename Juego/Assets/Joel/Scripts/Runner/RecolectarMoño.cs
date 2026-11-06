using UnityEngine;

namespace Joel
{
    public class RecolectarMoño : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                PlayerStats jugador =
                    collision.GetComponent<PlayerStats>();

                if (jugador != null)
                {
                    jugador.tieneMoño = true;
                    Destroy(gameObject);
                }
            }
        }
    }
}