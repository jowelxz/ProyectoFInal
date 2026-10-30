using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int vidaActual = 100;
    public int vidaMaxima = 100;
    public bool tieneEscudo = false;
    public GameObject pachesEquipado;

    void Update()
    {
        pachesEquipado.SetActive(tieneEscudo);
    }

    public void SumarVida(int cantidad)
    {
        vidaActual += cantidad;

        if (vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
    }

    public void RestarVida(int daño)
    {
        vidaActual -= daño;

        if (vidaActual < 0)
            vidaActual = 0;

        Debug.Log("Vida actual: " + vidaActual);

        if (vidaActual <= 0)
            Debug.Log("GAME OVER");
    }
}