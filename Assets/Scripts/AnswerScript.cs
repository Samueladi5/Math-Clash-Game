using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    [SerializeField] private bool isCorrectAnswer;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(CheckAnswer);
    }

    private void CheckAnswer()
    {
        if (isCorrectAnswer)
        {
            Debug.Log("Jawaban Anda benar!");
        }
        else
        {
            Debug.Log("Jawaban Anda salah!");
        }
    }
}
