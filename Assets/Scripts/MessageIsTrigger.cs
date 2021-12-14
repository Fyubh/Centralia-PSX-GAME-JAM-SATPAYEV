using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageIsTrigger : MonoBehaviour
{
    [SerializeField] private string text;
    private SubtitlesManager subtitlesManager;

    // Start is called before the first frame update
    void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
        }subtitlesManager.ShowSubtitles(text, 5);
    }
}
