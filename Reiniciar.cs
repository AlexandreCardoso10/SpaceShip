using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Pontuação.pontuacao = 0;
            FimJogo.jogadorMorto = false;
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene");
        }

        

    }
}
