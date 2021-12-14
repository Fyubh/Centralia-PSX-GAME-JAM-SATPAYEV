using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Note;
    private PlayerController PlayerController;
    private bool isRead = false;
    private SubtitlesManager subtitlesManager;
    // Start is called before the first frame update
    private void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
        PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Note.SetActive(false);
            PlayerController.isReadNode = false;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isRead)
        {
            subtitlesManager.ShowSubtitles("Чтоб перестать читать нажмите Space", 5f);
            PlayerController.isReadNode = true;
            Note.SetActive(true);
            isRead = true;
        }
    }
}
