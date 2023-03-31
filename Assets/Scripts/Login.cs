using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{

    public InputField usernameInput;
    public InputField passwordInput;
    public Button LoginButton;
    public Button goToRegisterButton;

    ArrayList credentials;
    //numbers button
    public Button numbers0; public Button numbers1; public Button numbers2;
    public Button numbers3; public Button numbers4; public Button numbers5;
    public Button numbers6; public Button numbers7; public Button numbers8;
    public Button numbers9;

    //letters button
    public Button LetterQ; public Button LetterW; public Button LetterE; public Button LetterR; public Button LetterT; public Button LetterY;
    public Button LetterU; public Button LetterI; public Button LetterP; public Button LetterA; public Button LetterS; public Button LetterD;
    public Button LetterF; public Button LetterG; public Button LetterH; public Button LetterJ; public Button LetterK; public Button LetterL;
    public Button LetterZ; public Button LetterX; public Button LetterC; public Button LetterV; public Button LetterB; public Button LetterN;
    public Button LetterM; public Button LetterO;

    //show error
    public Text showError;
    //select inputfield
    public int inputFieldSelect = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoginButton.onClick.AddListener(login);
        goToRegisterButton.onClick.AddListener(moveToRegister);
       

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            
            Debug.Log("Credential file doesn't exist.");
        }

        if(usernameInput.isActiveAndEnabled)
        {
            inputFieldSelect = 0;
            numbers0.onClick.AddListener(number0Type);
            numbers1.onClick.AddListener(number1Type);
            numbers2.onClick.AddListener(number2Type);
            numbers3.onClick.AddListener(number3Type);
            numbers4.onClick.AddListener(number4Type);
            LetterA.onClick.AddListener(LetterAType);
            LetterB.onClick.AddListener(LetterBType);
           
        }
        else if (passwordInput.isActiveAndEnabled)
        {
            inputFieldSelect = 1;
            numbers0.onClick.AddListener(number0Type);
            numbers1.onClick.AddListener(number1Type);
            numbers2.onClick.AddListener(number2Type);
            numbers3.onClick.AddListener(number3Type);
            numbers4.onClick.AddListener(number4Type);
            
            LetterA.onClick.AddListener(LetterAType);
            LetterB.onClick.AddListener(LetterBType);
        }





        //numbers1.onClick.AddListener(number1Type);
        //numbers2.onClick.AddListener(number2Type);
        //numbers3.onClick.AddListener(number3Type);
        //numbers4.onClick.AddListener(number4Type);
        //numbers5.onClick.AddListener(number5Type);
        //numbers6.onClick.AddListener(number6Type);
        //numbers7.onClick.AddListener(number7Type);
        //numbers8.onClick.AddListener(number8Type);
        //numbers9.onClick.AddListener(number9Type);
        //LetterA.onClick.AddListener(LetterAType);
        //LetterB.onClick.AddListener(LetterBType);
        //LetterC.onClick.AddListener(LetterCType);
        //LetterD.onClick.AddListener(LetterDType);
        //LetterE.onClick.AddListener(LetterEType);
        //LetterF.onClick.AddListener(LetterFType);
        //LetterG.onClick.AddListener(LetterGType);
        //LetterH.onClick.AddListener(LetterHType);
        //LetterI.onClick.AddListener(LetterIType);
        //LetterJ.onClick.AddListener(LetterJType);
        //LetterK.onClick.AddListener(LetterKType);
        //LetterL.onClick.AddListener(LetterLType);
        //LetterM.onClick.AddListener(LetterMType);
        //LetterN.onClick.AddListener(LetterNType);
        //LetterO.onClick.AddListener(LetterOType);
        //LetterP.onClick.AddListener(LetterPType);
        //LetterQ.onClick.AddListener(LetterQType);
        //LetterR.onClick.AddListener(LetterRType);
        //LetterS.onClick.AddListener(LetterSType);
        //LetterT.onClick.AddListener(LetterTType);
        //LetterU.onClick.AddListener(LetterUType);
        //LetterV.onClick.AddListener(LetterVType);
        //LetterW.onClick.AddListener(LetterWType);
        //LetterX.onClick.AddListener(LetterXType);
        //LetterY.onClick.AddListener(LetterYType);
        //LetterZ.onClick.AddListener(LetterZType);
    }
   

    void login()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(usernameInput.text)  &&
                i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            Debug.Log("go to next step");
            loadNextStepScreen();
        }
        else
        {
            showError.text = "Incorrect username or password!";
            Debug.Log("Incorrect credentials");
        }
    }

    void moveToRegister()
    {
        SceneManager.LoadScene("Register");
    }

    void loadNextStepScreen()
    {
        SceneManager.LoadScene("TOTP");
    }

    void selectInputfield()
    {
        switch (inputFieldSelect)
        {
            case 0: usernameInput.Select();
                numbers0.onClick.AddListener(number0TypeUsername) ;
                numbers1.onClick.AddListener(number1TypeUsername);
                

                
                break;
            case 1: passwordInput.Select();
                numbers0.onClick.AddListener(number0TypePassword);
                numbers1.onClick.AddListener(number1TypePassword);

                break;
        }
    }

    void number0Type()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "0";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "0";

                break;
        }
    }
    void number1Type()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "1";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "1";

                break;
        }
    }
    void number2Type()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "2";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "2";

                break;
        }
    }
    void number3Type()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "3";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "3";

                break;
        }
    }
    void number4Type()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "4";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "4";

                break;
        }
    }
    void LetterAType()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "A";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "A";

                break;
        }
    }
    void LetterBType()
    {
        switch (inputFieldSelect)
        {
            case 0:
                usernameInput.Select();
                usernameInput.text += "B";



                break;
            case 1:
                passwordInput.Select();
                passwordInput.text += "B";

                break;
        }
    }
    // Update is called once per frame
    void number0TypeUsername()
    {

        usernameInput.text += "0";
            
    }
    void number0TypePassword()
    {
            passwordInput.text += "0";        
    }
    void number1TypeUsername()
    {
        usernameInput.text += "1";
    }
    void number1TypePassword()
    {
        passwordInput.text += "1";
    }
}
