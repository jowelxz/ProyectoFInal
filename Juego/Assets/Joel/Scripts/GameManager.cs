using UnityEngine;
using UnityEngine.SceneManagement;

namespace Joel
{
    public class GameManager : MonoBehaviour
    {
        public GameObject panelGanaste;
        public GameObject panelPerdiste;
        public GameObject panelPausa;

        public void MostrarGanaste()
        {
            PlayerPrefs.SetInt("Nivel2Desbloqueado", 1);
            PlayerPrefs.Save();

            panelGanaste.SetActive(true);
            MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void MostrarPerdiste()
        {
            panelPerdiste.SetActive(true);
            MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void MostrarPausa()
        {
            panelPausa.SetActive(true);
            MusicManager.instancia.PausarMusica();
            Time.timeScale = 0f;
        }

        public void ReanudarJuego()
        {
            panelPausa.SetActive(false);
            MusicManager.instancia.ReanudarMusica();
            Time.timeScale = 1f;
        }

        public void ReiniciarNivel()
        {
            Time.timeScale = 1f;
            MusicManager.instancia.ReiniciarMusica();

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }

        public void IrAlMenuPrincipal()
        {
            Time.timeScale = 1f;
            MusicManager.instancia.ReanudarMusica();
            SceneManager.LoadScene("MenuInicial");
        }

        public void IrAlLobby()
        {
            Time.timeScale = 1f;
            MusicManager.instancia.ReanudarMusica();
            SceneManager.LoadScene("Lobby Joel");
        }
    }
}