using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverPlayerController : MonoBehaviour
{
    private PlayerController PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !PlayerController.isRevers)
        {
            PlayerController.isRevers = true;
        }
        else if (other.gameObject.CompareTag("Player") && PlayerController.isRevers)
        {
            PlayerController.isRevers = false;
        }
    }
}
