using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FimJogo : MonoBehaviour
{
    public static bool jogadorMorto = false;
    private Text fimJogo;

    // Start is called before the first frame update
    void Start()
    {
        fimJogo = GetComponent<Text>();
        fimJogo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(jogadorMorto)
        {
            Time.timeScale = 0;
            fimJogo.enabled = true;
        }
    }
}
