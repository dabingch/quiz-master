using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question")]
public class QuestionSO : ScriptableObject 
{   
    [TextArea(2,6)] // 2 lines of text, 6 lines of space
    [SerializeField] string question = "Enter new question here";   
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;
    
    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

