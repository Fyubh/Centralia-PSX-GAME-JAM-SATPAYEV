using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClowneMove : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private Text text;
    [SerializeField] private GameObject black;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector3.ClampMagnitude(new Vector3(0, 0, 1), 1) * 6;
    }

    IEnumerator TheEnd()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        text.gameObject.SetActive(false);
        black.gameObject.SetActive(false);
        SceneManager.LoadScene("SecondScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            black.gameObject.SetActive(true);
            StartCoroutine(TheEnd());
        }
    }
}
