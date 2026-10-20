using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int vida = 100;

    public void RestarVida(int daño)
    {
        vida -= daño;

        if (vida < 0)
            vida = 0;

        Debug.Log("Vida actual: " + vida);

        if (vida <= 0)
            Debug.Log("GAME OVER");
    }
}