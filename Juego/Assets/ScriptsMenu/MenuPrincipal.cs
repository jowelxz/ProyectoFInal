using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public Button botonNivel2;

    void Start()
    {
        bool nivel2Desbloqueado =
            PlayerPrefs.GetInt("Nivel2Desbloqueado", 0) == 1;

        botonNivel2.interactable = nivel2Desbloqueado;
    }

    public void IrANivel1()
    {
        SceneManager.LoadScene("Lobby Joel");
    }

    public void IrANivel2()
    {
        if (PlayerPrefs.GetInt("Nivel2Desbloqueado", 0) == 1)
        {
            SceneManager.LoadScene("Lobby Samuel");
        }
    }
}