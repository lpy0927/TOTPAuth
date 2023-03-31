using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TOTP : MonoBehaviour
{

    //set up time
    float currentTime = 0f;
    float startingTime = 60f;

    public Text countDownText;

    public InputField codeInput;
    public Text showSixDigits;
    public Button loginButton;
    public int number1;

    public Button numbers0; public Button numbers1; public Button numbers2;
    public Button numbers3; public Button numbers4; public Button numbers5;
    public Button numbers6; public Button numbers7; public Button numbers8;
    public Button numbers9;

    public Button Fresh;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        generateSixDigits();
        showSixDigits.text = number1.ToString();
        loginButton.onClick.AddListener(login);
        numbers0.onClick.AddListener(number0Type);
        numbers1.onClick.AddListener(number1Type);
        numbers2.onClick.AddListener(number2Type);
        numbers3.onClick.AddListener(number3Type);
        numbers4.onClick.AddListener(number4Type);
        numbers5.onClick.AddListener(number5Type);
        numbers6.onClick.AddListener(number6Type);
        numbers7.onClick.AddListener(number7Type);
        numbers8.onClick.AddListener(number8Type);
        numbers9.onClick.AddListener(number9Type);

        Fresh.onClick.AddListener(resendToken);

    }

    // login 
    void login()
    {
        bool isExists = false;

        if (showSixDigits.text.Equals(codeInput.text) && countDownText.text != "0")
        {
            isExists = true;

        }
        if (isExists)
        {
            Debug.Log("Logging in");
            loadWelcomeScene();
        }
    }

    //generate six digits
    void generateSixDigits()
    {
        number1 = Mathf.RoundToInt(UnityEngine.Random.Range(100000.0f, 1000000.0f));
    }

    // load welcome scene
    void loadWelcomeScene()
    {
        SceneManager.LoadScene("Welcome");

    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1f * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if (currentTime <= 0f)
        {
            countDownText.text = "o";
        }
    }

    // resend the token
    void resendToken()
    {
        currentTime = 60f;
        generateSixDigits();
        showSixDigits.text = number1.ToString();
        codeInput.text = "";
    }

    void number0Type()
    {
        codeInput.text += "0";
    }
    void number1Type()
    {
        codeInput.text += "1";
    }
    void number2Type()
    {
        codeInput.text += "2";
    }
    void number3Type()
    {
        codeInput.text += "3";
    }
    void number4Type()
    {
        codeInput.text += "4";
    }
    void number5Type()
    {
        codeInput.text += "5";
    }
    void number6Type()
    {
        codeInput.text += "6";
    }
    void number7Type()
    {
        codeInput.text += "7";
    }
    void number8Type()
    {
        codeInput.text += "8";
    }
    void number9Type()
    {
        codeInput.text += "9";
    }

}
