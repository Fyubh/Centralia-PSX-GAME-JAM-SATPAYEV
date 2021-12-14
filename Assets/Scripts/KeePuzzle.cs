using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeePuzzle : MonoBehaviour
{

    private PlayerController playerController;
    private SubtitlesManager subtitlesManager;

    // Start is called before the first frame update
    void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerController.keyFromGate = true;
            subtitlesManager.ShowSubtitles("Найден ключ с надписью *Администрация*", 5);
        }
    }
}
