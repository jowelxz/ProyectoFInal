using UnityEngine;
using UnityEngine.SceneManagement;

namespace Joel
{
    public class LobbyManager : MonoBehaviour
    {
        public string nombreNivel = "Nivel 1";

        public GameObject panelCreditos;

        public void MostrarCreditos()
        {
            panelCreditos.SetActive(true);
        }

        public void CerrarCreditos()
        {
            panelCreditos.SetActive(false);
        }

        public void Jugar()
        {
            SceneManager.LoadScene(nombreNivel);
        }

        public void IrAlMenu()
        {
            SceneManager.LoadScene("MenuInicial");
        }

        public void Salir()
        {
            Application.Quit();
        }
    }
}