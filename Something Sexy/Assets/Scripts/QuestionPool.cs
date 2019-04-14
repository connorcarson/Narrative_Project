using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuestionPool
{
    public string question1Text;
    public string question2Text;
    public string question3Text;
    public string question4Text;
    public string question5Text;
    public string question6Text;
    public string question7Text;
    public string question8Text;
    public string question9Text;
    public string question10Text;
    public string question11Text;
    public string question12Text;
    public string question13Text;
    public string question14Text;
    public string question15Text;
    public string question16Text;
    public string question17Text;
    public string question18Text;
    public string question19Text;
    public string question20Text;
    

    public static QuestionPool CreatFromJson(string jsonStr)
    {
        return JsonUtility.FromJson<QuestionPool>(jsonStr);
    }
}

