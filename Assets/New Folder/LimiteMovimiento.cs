using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float limiteMax = 4;
    public float limiteMin = -4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > limiteMax) //El objeto se pasa por encima
        {
            Vector3 newpos = transform.position; //guardo la posicion actual 
            newpos.y = limiteMax; //modifico la y de la posicion guardada
            transform.position = newpos; //aplico la posicion guardada a la posicion
        }

        if (transform.position.y < limiteMin) //El objeto se pasa por encima
        {
            Vector3 newpos = transform.position; //guardo la posicion actual 
            newpos.y = limiteMin; //modifico la y de la posicion guardada
            transform.position = newpos; //aplico la posicion guardada a la posicion
        }

    }
} 