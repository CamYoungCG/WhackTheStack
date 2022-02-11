using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailDetection : MonoBehaviour
{
    public GameObject player2;
    public Text failText;

    void Start()
    {
        failText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider floor)
    {
        if (floor.gameObject.CompareTag("Player2"))
            failText.gameObject.SetActive(true);
    }
}
