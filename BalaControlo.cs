using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControlo : MonoBehaviour
{

    private Transform bala;
    public float veloz;
    // Start is called before the first frame update
    void Start()
    {
        bala = GetComponent<Transform> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bala.position += Vector3.up * veloz;

        if(bala.position.y >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Inimigo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Pontuação.pontuacao += 10;
        }
    }
}
