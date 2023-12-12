using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathQuestionPopUp : MonoBehaviour
{
    public GameObject mathQuestionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Spawn the math question popup
            Instantiate(mathQuestionPrefab, transform.position, Quaternion.identity);

            // Disable the enemy temporarily
            gameObject.SetActive(false);
        }
    }
}

