using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffCamera : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private Camera onCameraFirst; // Не было времени сделать массив (FIX ЕСЛИ БУДЕТ ВРЕМЯ)
    [SerializeField] private Camera onCameraSecond;
    [SerializeField] private GameObject onClown;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            camera.gameObject.SetActive(false);
            onCameraFirst.gameObject.SetActive(true);
            onCameraSecond.gameObject.SetActive(true);
            onClown.gameObject.SetActive(true);
        }
    }
}
