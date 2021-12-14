using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchTrigger : MonoBehaviour
{
    [SerializeField] private GameObject FlashLight;
    [SerializeField] private GameObject Flash;
    private SubtitlesManager subtitlesManager;
    // Start is called before the first frame update
    private void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlashLight.SetActive(true);
            Flash.SetActive(true);
            gameObject.SetActive(false);
            subtitlesManager.ShowSubtitles("Вы получили фонарик", 5f);
        }
    }
}
