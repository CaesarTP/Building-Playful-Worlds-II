using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static bool coinCollected;
    public static bool coinDevoured;
    public static bool winConCoin;
    public static bool devouredLoseCon;
    public float speed = 50f;

    void Start()
    {
        coinCollected = false;
        coinDevoured = false;
        winConCoin = false;
        devouredLoseCon = false;
    }

    void Update()
    {
        transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube")) 
        {
            coinCollected = true;
            winConCoin = true;
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Spike"))
        {
            coinDevoured = true;
            devouredLoseCon = true;
            Destroy(gameObject);
        }
    }
}
