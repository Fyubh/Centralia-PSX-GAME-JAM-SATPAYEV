using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour
{
    private PlayerController PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.firstMusicOff = true;
        }
    }
}
