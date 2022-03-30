using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static bool cubesConjoined;
    public static bool winConConjoined;
    public static bool destroyedLoseCon;

    [SerializeField]
    float moveSpeed = 0.25f;

    [SerializeField]
    float rayLength = 0.55f;

    Vector3 targetPosition;
    Vector3 startPosition;

    bool moving;
    void Start()
    {
        cubesConjoined = false;
        winConConjoined = false;
        destroyedLoseCon = false;
    }

    void Update()
    {
        //MOVEMENT MOVEMENT MOVEMENT

        Debug.DrawRay(transform.position, Vector3.forward * 0.55f, Color.green);
        Debug.DrawRay(transform.position, Vector3.right * 0.55f, Color.green);
        Debug.DrawRay(transform.position, Vector3.left * 0.55f, Color.green);
        Debug.DrawRay(transform.position, Vector3.back * 0.55f, Color.green);

        if (!moving)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!Physics.Raycast(transform.position, Vector3.forward, rayLength))
                {
                    targetPosition = transform.position + Vector3.forward;
                    startPosition = transform.position;
                    moving = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (!Physics.Raycast(transform.position, Vector3.back, rayLength))
                {
                    targetPosition = transform.position + Vector3.back;
                    startPosition = transform.position;
                    moving = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (!Physics.Raycast(transform.position, Vector3.right, rayLength))
                {
                    targetPosition = transform.position + Vector3.right;
                    startPosition = transform.position;
                    moving = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (!Physics.Raycast(transform.position, Vector3.left, rayLength))
                {
                    targetPosition = transform.position + Vector3.left;
                    startPosition = transform.position;
                    moving = true;
                }
            }
        }

        if (moving)
        {
            if (Vector3.Distance(startPosition, transform.position) > 1f)
            {
                transform.position = targetPosition;
                moving = false;
                return;
            }

            transform.position += (targetPosition - startPosition) * moveSpeed * Time.deltaTime;
            return;
        }

        // EXTRA WIN-LOSE CONDITION CHECKS

        if (Spike.cubeDestroyed == true)
        {
            moveSpeed = 0;
        }

        if (Coin.coinDevoured == true)
        {
            moveSpeed = 0;
        }

        if (Coin.winConCoin == true && Cube.winConConjoined == true) 
        {
            moveSpeed = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube")) 
        {
            cubesConjoined = true;
            winConConjoined = true;
        }

        if (other.gameObject.CompareTag("Spike")) 
        {
            destroyedLoseCon = true;
            Destroy(gameObject);
        }
    }
}
