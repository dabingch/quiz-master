using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question")]
public class QuestionSO : ScriptableObject 
{   
    [TextArea(2,6)] // 2 lines of text, 6 lines of space
    [SerializeField] string question = "Enter new question here";   
}

