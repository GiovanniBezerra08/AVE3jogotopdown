using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private int dano = 1;
    [SerializeField] private float velocidade = 1.5f;

    [Header("Som da Bala")]
    [SerializeField] private AudioClip somDisparo; // Som a ser tocado ao disparar
    [SerializeField] private float volumeSom = 1f;

    private Renderer m_Renderer;
    private AudioSource audioSource;

    public void setDano(int dano)
    {
        this.dano = dano;
    }

    public int getDano()
    {
        return this.dano;
    }

    void Start()
    {
        m_Renderer = GetComponent<Renderer>();

        // Cria um AudioSource temporário para tocar o som
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = somDisparo;
        audioSource.volume = volumeSom;
        audioSource.playOnAwake = false;

        if (somDisparo != null)
        {
            audioSource.Play(); // Toca o som quando a bala é ativada
        }
    }

    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (!m_Renderer.isVisible)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            // Causa dano ao Inimigo
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVida() - getDano();
            collision.gameObject.GetComponent<Personagem>().setVida(novaVida);
        }

        Destroy(gameObject);
    }
}