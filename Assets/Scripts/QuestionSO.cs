using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// adding the menu in right click option menu
[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // TextArea MIN, MAX line of text
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answer = new string[4];
    [SerializeField] int correctAnswerIndex;
    
    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answer[index];
    }
    
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

}

