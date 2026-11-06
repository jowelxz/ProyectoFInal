using UnityEngine;
using TMPro;

namespace Joel
{
    public class Temporizador : MonoBehaviour
    {
        public TMP_Text textoTemporizador;
        public float tiempo = 300f;

        void Update()
        {
            if (tiempo > 0)
            {
                tiempo -= Time.deltaTime;

                int minutos = Mathf.FloorToInt(tiempo / 60);
                int segundos = Mathf.FloorToInt(tiempo % 60);

                textoTemporizador.text =
                    minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            {
                tiempo = 0;
                textoTemporizador.text = "00:00";

                FindFirstObjectByType<GameManager>().MostrarPerdiste();

                enabled = false;
            }
        }
    }
}