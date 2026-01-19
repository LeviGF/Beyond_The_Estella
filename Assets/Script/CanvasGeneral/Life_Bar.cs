using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.UI;

public class Life_Bar : MonoBehaviour
{
    [SerializeField] public Image barImage; //Aqui va la imagen de vara de vida
    private Enemy_Life Enemy_Life;
    private Player_life_Battle player_Life_Battle;
    //private float vidaMax;

    void Start()
    {
        Enemy_Life = GameObject.Find("Alien Battle A").GetComponent<Enemy_Life>();
        player_Life_Battle = GameObject.Find("Player Battle").GetComponent<Player_life_Battle>();
    }

    public void UpdateLifeBar( float vida, float vidaMax)
    {
        barImage.fillAmount = vida / vidaMax;
    }
    void Update()
    {
        //barImage = fillAmount = Enemy_Life.vida / vidaMax; 
    }
}
