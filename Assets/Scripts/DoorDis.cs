using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDis : MonoBehaviour
{
    [SerializeField] private GameObject gateFirst;
    [SerializeField] private GameObject gateSecond;

    private PlayerController PlayerController;
    private SubtitlesManager subtitlesManager;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();

    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && PlayerController.keyFromGate)
        {
            gateFirst.SetActive(false);
            gateSecond.SetActive(false);
            subtitlesManager.ShowSubtitles("Ворота открыты", 5);
        }
    }
}
