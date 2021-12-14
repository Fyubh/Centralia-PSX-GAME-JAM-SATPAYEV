using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFowardZ : MonoBehaviour
{
    private GameObject Player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z + offset.z);
    }
}
