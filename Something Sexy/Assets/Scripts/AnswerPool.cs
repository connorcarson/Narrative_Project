using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnswerPool
{
    public string answer1Text;
    public string answer2Text;
    public string answer3Text;
    public string answer4Text;
    public string answer5Text;
    public string answer6Text;
    public string answer7Text;
    public string answer8Text;
    public string answer9Text;
    public string answer10Text;
    public string answer11Text;
    public string answer12Text;
    public string answer13Text;
    public string answer14Text;
    public string answer15Text;
    public string answer16Text;
    public string answer17Text;
    public string answer18Text;
    public string answer19Text;
    public string answer20Text;
    

    public static AnswerPool CreatFromJson(string jsonStr)
    {
        return JsonUtility.FromJson<AnswerPool>(jsonStr);
    }
}

