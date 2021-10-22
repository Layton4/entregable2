using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour

{
[SerializeField] private bool isGameOver;
private int playerHP = 150;
public int damage = 60;


    void Start()
    {
        playerHP -= damage;
        
    }

    void Update()
    {
        if (isGameOver == false)
        {
            if (playerHP <= 0)
            {
                isGameOver = true;
                Debug.Log("Te has quedado sin vida... GAME OVER");
            }
            else if (playerHP < 30)
            {
                Debug.Log("¡¡¡Tienes poca vida!!!");
            }
            else
            {
                Debug.Log($"Vas bién de vida: tienes {playerHP} puntos de vida");
            }
        }
        else
        {
            Debug.Log("GAME OVER");
        }

    }
}
