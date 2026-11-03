using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panelGanaste;

    public void MostrarGanaste()
    {
        panelGanaste.SetActive(true);
        Time.timeScale = 0f;
    }
}