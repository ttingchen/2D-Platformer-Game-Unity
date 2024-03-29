using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollider : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI applesText;
    [SerializeField] private AudioSource collectSoundEffect;
    private int apples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple")) // Tag name
        {
            // Remove item
            Destroy(collision.gameObject);
            apples ++;
            collectSoundEffect.Play();
            // Debug.Log("Apples: "+apples);
            applesText.text = "Apples: " + apples;
        }
    }
}
