using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pontuação : MonoBehaviour
{

    public static float pontuacao = 0;
    private Text pontuacaoText;



    // Start is called before the first frame update
    void Start()
    {
        pontuacaoText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pontuacaoText.text = "Pontuação:" + pontuacao;
    }
}
