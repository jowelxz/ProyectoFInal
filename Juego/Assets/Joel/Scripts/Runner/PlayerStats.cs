using UnityEngine;

namespace Joel
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] public int vida = 100;
        [SerializeField] public int vidaMaxima = 100;

        public int puntos = 0;

        public UIManager uiManager;

        public TMPro.TextMeshProUGUI textoPuntos;

        public bool tieneEscudo = false;
        public GameObject pachesEquipado;

        public bool tieneMoño = false;
        public GameObject moñoEquipado;

        void Update()
        {
            if (pachesEquipado != null)
                pachesEquipado.SetActive(tieneEscudo);

            if (moñoEquipado != null)
                moñoEquipado.SetActive(tieneMoño);
        }

        void Start()
        {
            ActualizarBarra();
        }

        public void SumarVida(int cantidad)
        {
            vida += cantidad;

            if (vida > vidaMaxima)
                vida = vidaMaxima;

            ActualizarBarra();
        }

        public void RestarVida(int daño)
        {
            vida -= daño;

            if (vida < 0)
                vida = 0;

            ActualizarBarra();

            if (vida <= 0)
            {
                FindFirstObjectByType<GameManager>().MostrarPerdiste();
                Debug.Log("GAME OVER");
            }
        }

        void ActualizarBarra()
        {
            if (uiManager == null || vidaMaxima <= 0)
                return;

            uiManager.SetFillAmount((float)vida / vidaMaxima);

            if (vida >= 80)
            {
                uiManager.ColorBarra(Color.green);
            }
            else if (vida > 40)
            {
                uiManager.ColorBarra(new Color(1f, 0.5f, 0f));
            }
            else
            {
                uiManager.ColorBarra(Color.red);
            }
        }

        public void SumarPuntos(int cantidad)
        {
            puntos += cantidad;

            if (textoPuntos != null)
                textoPuntos.text = puntos + " / 100";

            Debug.Log("Puntos actuales: " + puntos);
        }
    }
}