using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraDeVidaPlayer : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    
    public Personagem personagem;
    [SerializeField]
    private int vidasRestantes = 0;
    
  
    void Start()
    {
        if (personagem != null && sliderVidasRestantes != null)
        {
            sliderVidasRestantes.minValue = 0;
            sliderVidasRestantes.maxValue = personagem.getVida();
        }
    }

    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = personagem.getVida();
            sliderVidasRestantes.value = vidasRestantes;
        }

       
          
        if (sliderVidasRestantes.value == 0)
        {
            SceneManager.LoadScene(0);
        }

        
    }
  
  
}