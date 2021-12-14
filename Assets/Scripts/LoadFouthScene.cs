using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LoadFouthScene : MonoBehaviour
{
    private SubtitlesManager subtitlesManager;
    [SerializeField] private Text text;
    // Start is called before the first frame update
    void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
        subtitlesManager.ShowSubtitles("Последняя жертва, я верну своего сына", 10);
        StartCoroutine(SubtitlesTimer());
    }

    IEnumerator SubtitlesTimer()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        text.gameObject.SetActive(true);
    }
}
