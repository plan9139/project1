using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Button okbutton;

    public Button restartbutton;

    public InputField answerInputbox;

    public Text displayText;

    public Image Cat;

    public Image Cat1;

    string[] answers;

    string[] questions;

    int currentQuestionNumber = 0;

    int currentAnswerNumber = 0 ;

    void Start()
    {
        Cat.gameObject.SetActive(false);
        restartbutton.gameObject.SetActive(false);
        answers = new string[3];
        questions = new string[]{
            "What is your name?",
            "What is your fav anime?",
            "What is your fav color?",
            "What is your fav TV show?",
            "What is your fav food?",
            "What is your fav hobby?",
            "What is your fav animal?",
            "What is your fav place to travel?",
            "What is your fav games?",
            "Sea or Mountain?",
            "Marvel or DC?",
            "What is your fav artist?",
            "What is your fav movie?",
            "What is your fav song?",
            "Dog or Cat?",
            "Apple or Samsung?",
            "What is your fav anime character?"
        };

        displayText.text = questions[currentQuestionNumber];
    }

   public void printName()
    
    
    {
        
    
        answers[currentAnswerNumber] = answerInputbox.text;
        
        answerInputbox.text = "";

        currentAnswerNumber =currentAnswerNumber + 1;

        currentQuestionNumber = Random.Range(1, questions.Length);
        
        if(currentAnswerNumber <= 2)
        {
        
        displayText.text = questions[currentQuestionNumber];

        }
        else
        {
            displayText.text = answers[0] + " likes " + answers[1] + " and also likes " + answers[2] + ".";

            okbutton.gameObject.SetActive(false);
            answerInputbox.gameObject.SetActive(false);
            Cat1.gameObject.SetActive(false);
            Cat.gameObject.SetActive(true);
            restartbutton.gameObject.SetActive(true);
        }    
    }

    public void restart(){
        
       SceneManager.LoadScene("storybuiling");

    }    

    void Update()
    {
       //print(answerField.text);

    }
}
