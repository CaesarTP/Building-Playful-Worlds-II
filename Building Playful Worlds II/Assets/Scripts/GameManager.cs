using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject coin;
    public GameObject devoured;
    public GameObject destroyed;
    public GameObject collected;
    public GameObject conjoined;
    public GameObject win;

    void Start()
    {
        collected.SetActive(false);
        devoured.SetActive(false);
        destroyed.SetActive(false);
        conjoined.SetActive(false);
        Cube.cubesConjoined = false;
        Coin.coinCollected = false;
        Coin.coinDevoured = false;
        Spike.cubeDestroyed = false;
        Coin.winConCoin = false;
        Cube.winConConjoined = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            SceneManager.LoadScene("Level 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Level 2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Level 3");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Level 4");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Level 5");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("Level 6");
        }

        if (Coin.winConCoin == true && Cube.winConConjoined == true) 
        {
            win.SetActive(true);
            collected.SetActive(false);
            devoured.SetActive(false);
            destroyed.SetActive(false);
            conjoined.SetActive(false);
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
            Coin.coinDevoured = false;
            Spike.cubeDestroyed = false;
        }

        if (Coin.devouredLoseCon == true) 
        {
            devoured.SetActive(true);
            Coin.coinDevoured = true;

            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
            Spike.cubeDestroyed = false;
            collected.SetActive(false);
            destroyed.SetActive(false);
            conjoined.SetActive(false);
        }

        if (Cube.destroyedLoseCon == true) 
        {
            destroyed.SetActive(true);
            Spike.cubeDestroyed = true;

            collected.SetActive(false);
            devoured.SetActive(false);
            conjoined.SetActive(false);
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
            Coin.coinDevoured = false;
        }

        if (Coin.coinCollected == true) 
        {
            collected.SetActive(true);           
            devoured.SetActive(false);
            destroyed.SetActive(false);
            conjoined.SetActive(false);
            Spike.cubeDestroyed = false;
            Coin.coinDevoured = false;
            Cube.cubesConjoined = false;
        }

        if (Coin.coinDevoured == true) 
        {
            devoured.SetActive(true);
            collected.SetActive(false);
            destroyed.SetActive(false);
            conjoined.SetActive(false);
            Spike.cubeDestroyed = false;
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
        }

        if (Spike.cubeDestroyed == true) 
        {
            destroyed.SetActive(true);
            collected.SetActive(false);
            conjoined.SetActive(false);
            devoured.SetActive(false);
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
            Coin.coinDevoured = false;
        }

        if (Cube.cubesConjoined == true) 
        {
            conjoined.SetActive(true);
            devoured.SetActive(false);
            destroyed.SetActive(false);
            collected.SetActive(false);
            Coin.coinCollected = false;
            Coin.coinDevoured = false;
            Spike.cubeDestroyed = false;
        }

        if (cube == null) 
        {
            Spike.cubeDestroyed = true;
            destroyed.SetActive(true);
            collected.SetActive(false);
            conjoined.SetActive(false);
            devoured.SetActive(false);
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
            Coin.coinDevoured = false;
        }

        if (coin = null) 
        {
            Coin.coinDevoured = true;
            devoured.SetActive(true);
            collected.SetActive(false);
            destroyed.SetActive(false);
            conjoined.SetActive(false);
            Spike.cubeDestroyed = false;
            Cube.cubesConjoined = false;
            Coin.coinCollected = false;
        }
    }
}
