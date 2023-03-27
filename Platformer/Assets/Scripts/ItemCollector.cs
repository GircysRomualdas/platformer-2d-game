using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int frut = 0;
    [SerializeField] private TMP_Text frutText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Frut"))
        {
            Destroy(collision.gameObject);
            frut++;
            frutText.text = "Fruts: " + frut;
        }
    }
}
