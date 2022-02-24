using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaInimigo : MonoBehaviour
{

    private Transform bala;
    public float velz;
    // Start is called before the first frame update
    void Start()
    {
        bala = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bala.position += Vector3.up * -velz;

        if(bala.position.y <= -10)
        {
            Destroy(bala.gameObject);
        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Jogador")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            FimJogo.jogadorMorto = true;
        }
    }
}
