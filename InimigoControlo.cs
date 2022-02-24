using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InimigoControlo : MonoBehaviour
{
    public float velozDoIni;
    private Transform inimigoHol;

    public GameObject disparar;
    public Text winText;
    public float velDoDisDoIni = 0.9f;
    // Start is called before the first frame update
    void Start()
    {

        //winText.enabled = false;
        InvokeRepeating("MoverInig", 0.3f, 0.5f);
        inimigoHol = GetComponent<Transform>();
    }

    // Update is called once per frame
    void MoverInig()
    {
        inimigoHol.position += Vector3.down * velozDoIni;

        foreach (Transform inimigo in inimigoHol)
        {
            if(inimigo.position.y < -4)
            {
                FimJogo.jogadorMorto = true;
                Time.timeScale = 0;
            }

            if (Random.Range(-10.0f,1.0f) > velDoDisDoIni)
            {
                Instantiate(disparar, inimigo.position, inimigo.rotation);
            }
        }
        
        if(inimigoHol.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoverInig", 0.1f, 0.25f);
        }

        if (inimigoHol.childCount == 0)
        {
            winText.enabled = true;
        }
    }
}
