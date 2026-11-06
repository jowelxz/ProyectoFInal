using UnityEngine;
using UnityEngine.SceneManagement;

namespace Samuel
{
    public class GameManager : MonoBehaviour
    {
        public GameObject panelGanaste;
        public GameObject panelPerdiste;
        public GameObject panelPausa;

        public void MostrarGanaste()
        {
            panelGanaste.SetActive(true);
            Joel.MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void MostrarPerdiste()
        {
            panelPerdiste.SetActive(true);
            Joel.MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void MostrarPausa()
        {
            panelPausa.SetActive(true);
            Joel.MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void ReanudarJuego()
        {
            panelPausa.SetActive(false);
            Joel.MusicManager.instancia.ReanudarMusica();
            Time.timeScale = 1f;
        }

        public void ReiniciarNivel()
        {
            Time.timeScale = 1f;
            Joel.MusicManager.instancia.ReiniciarMusica();

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }

        public void IrAlMenuPrincipal()
        {
            Time.timeScale = 1f;
            Joel.MusicManager.instancia.ReanudarMusica();
            SceneManager.LoadScene("MenuInicial");
        }

        public void IrAlLobby()
        {
            Time.timeScale = 1f;
            Joel.MusicManager.instancia.ReanudarMusica();
            SceneManager.LoadScene("Lobby Samuel");
        }
    }
}