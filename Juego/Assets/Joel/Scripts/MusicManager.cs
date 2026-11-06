using UnityEngine;

namespace Joel
{
    public class MusicManager : MonoBehaviour
    {
        public static MusicManager instancia;

        private AudioSource audioSource;

        void Awake()
        {
            if (instancia == null)
            {
                instancia = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
                return;
            }

            audioSource = GetComponent<AudioSource>();
        }

        void Start()
        {
            audioSource.Play();
        }

        public void PausarMusica()
        {
            audioSource.Pause();
        }

        public void ReanudarMusica()
        {
            audioSource.UnPause();
        }

        public void ReiniciarMusica()
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }
}