using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesManager : MonoBehaviour
{
    [SerializeField] private Text subtitles;
    private float Seconds;
    // Start is called before the first frame update
    void Start()
    {
        subtitles = GameObject.Find("Subtitles").GetComponent<Text>();
    }

    IEnumerator SubtitlesTimer()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(Seconds);
        subtitles.gameObject.SetActive(false);
    }

    public void ShowSubtitles(string text, float seconds)
    {
        subtitles.text = text;
        Seconds = seconds;
        subtitles.gameObject.SetActive(true);
        StartCoroutine(SubtitlesTimer());

    }
}
