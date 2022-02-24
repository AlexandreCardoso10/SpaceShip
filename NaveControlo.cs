using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NaveControlo : MonoBehaviour
{

    public float velocidade;
    public float limiteEsq;
    public float limiteDir;
    private Transform jogador;
    public GameObject disparo;
    public Transform PosInicDis;
    public float velozDispar;
    private float proDis;


    // Start is called before the first frame update
    void Start()
    {
        jogador = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (jogador.position.x > limiteEsq && horizontal < 0)
            horizontal = -1;
        else if (jogador.position.x < limiteDir && horizontal > 0)
            horizontal = 1;

        jogador.position += Vector3.right * horizontal * velocidade;
    }

    private void Update()
    {
       if(Input.GetButton("Fire1") && Time.time > proDis)
        {
            proDis = Time.time + velozDispar;
            Instantiate(disparo, PosInicDis.position, PosInicDis.rotation);
        }
    }
}
