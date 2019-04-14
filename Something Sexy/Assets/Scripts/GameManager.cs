using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public QANode currentNode;
    
    private string questionJSON;
    private string answerJSON;

    public string[] questionPool;
    public string[] answerPool;

    public Text question1Text;
    public Text question2Text;
    public Text question3Text;
    public Text answerText;

    public Button question1Button;
    public Button question2Button;
    public Button question3Button;

    public GameObject answerDialogue;
    public GameObject nextButton;

    public int questionIndex;
    public int answerIndex;
    
    public int question1Index;
    public int question2Index;
    public int question3Index;
    
    // Start is called before the first frame update
    void Start()
    {
        questionJSON = Application.dataPath + "/Text/AllQuestions.json";
        string allQuestionText = File.ReadAllText(questionJSON);
        QuestionPool questions = QuestionPool.CreatFromJson(allQuestionText);

        questionPool = new[]
        {
            questions.question1Text, questions.question2Text, questions.question3Text, questions.question4Text,
            questions.question5Text, questions.question6Text, questions.question7Text, questions.question8Text,
            questions.question9Text, questions.question10Text, questions.question11Text, questions.question12Text,
            questions.question13Text, questions.question14Text, questions.question15Text, questions.question16Text,
            questions.question17Text, questions.question18Text, questions.question19Text, questions.question20Text
        };

        answerJSON = Application.dataPath + "/Text/AllAnswers.json";
        string allAnswerText = File.ReadAllText(answerJSON);
        AnswerPool answers = AnswerPool.CreatFromJson(allAnswerText);

        answerPool = new[]
        {
            answers.answer1Text, answers.answer2Text, answers.answer3Text, answers.answer4Text,
            answers.answer5Text, answers.answer6Text, answers.answer7Text, answers.answer8Text,
            answers.answer9Text, answers.answer10Text, answers.answer11Text, answers.answer12Text,
            answers.answer13Text, answers.answer14Text, answers.answer15Text, answers.answer16Text,
            answers.answer17Text, answers.answer18Text, answers.answer19Text, answers.answer20Text
        };
        
        UpdateUI();

        //WriteNewJson(fileLocation); //use to creat new Json file, if file does not already exist.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void WriteNewJson(string fileLocation)
    {
        currentNode = new QANode(
            1, 
            "this will be question 1",
            "this will be question 2",
            "this will be question 3",
            "this will be answer 1",
            "this will be answer 2",
            "this will be answer 3");

        string JsonStr = JsonUtility.ToJson(currentNode, true);
        
        File.WriteAllText(fileLocation, JsonStr);
    }*/

    /*void ReadFromJson(string fileLocation)
    {
        string question = File.ReadAllText(fileLocation);
        currentNode = JsonUtility.FromJson<QANode>(question);
    }*/

    public void ChooseQuestion(int questionNum)
    {
        question1Button.interactable = false;
        question2Button.interactable = false;
        question3Button.interactable = false;
        
        answerDialogue.SetActive(true);
        nextButton.SetActive(true);

        switch (questionNum)
        {
            case 1:
                questionIndex = question1Index;
                break;
            case 2:
                questionIndex = question2Index;
                break;
            case 3:
                questionIndex = question3Index;
                break;
            default:
                break;
        }
        
        answerIndex = questionIndex;
        answerText.text = answerPool[answerIndex];
    }

    void UpdateUI()
    {
        question1Index = Random.Range(0, questionPool.Length);        
        question2Index = Random.Range(0, questionPool.Length);
        question3Index = Random.Range(0, questionPool.Length);
        
        if (question1Index == question2Index || question1Index == question3Index || question2Index == question3Index)
        {
            UpdateUI();
        }
        else
        {
            string currentQuestion1 = questionPool[question1Index];
            string currentQuestion2 = questionPool[question2Index];
            string currentQuestion3 = questionPool[question3Index];
        
            question1Text.text = currentQuestion1;
            question2Text.text = currentQuestion2;
            question3Text.text = currentQuestion3;
        }
    }
}
