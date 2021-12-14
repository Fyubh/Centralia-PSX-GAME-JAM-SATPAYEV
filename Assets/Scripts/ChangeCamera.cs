using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private GameObject firstCamera;
    [SerializeField] private GameObject secondCamera;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (firstCamera.gameObject.activeSelf)
            {
                firstCamera.SetActive(false);
                secondCamera.SetActive(true);
            }
            else
            {
                secondCamera.SetActive(false);
                firstCamera.SetActive(true);
            }
        }
    }
}
