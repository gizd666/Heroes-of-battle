using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreate : MonoBehaviour
{
    public GUISkin skin;
    public float buttonWidth = 60;
    public float buttonHeight = 60;

    private float buttonMargin = 10;
    public string passwordToEdit = "My Password";
    // Use this for initialization
    public string stringToEdit = "Login";

    private float maxStreanght = 10;
    private float currentStreanght = 5;
    private float maxIntleigence = 10;
    private float currentInteligence = 5;
    private float maxPerception = 10;
    private float currentPerception = 5;

    void OnGUI()
    {
        GUI.skin = skin;
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
        {
            passwordToEdit = GUI.PasswordField(new Rect(10, 40, 200, 20), passwordToEdit, "*"[0], 25);
        }

        if (GUI.Button(new Rect(300, 300, buttonWidth, buttonHeight), "-"))
        {
        
        }

        if (GUI.Button(new Rect(300, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "-"))
        {

        }

        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "-"))
        {
         
        }

        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 3, buttonWidth, buttonHeight), "-"))
        {
        
        }

        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 4, buttonWidth, buttonHeight), "-"))
        {
       
        }

        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 5, buttonWidth, buttonHeight), "-"))
        {

        }
        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 6, buttonWidth, buttonHeight), "-"))
        {

        }
        if (GUI.Button(new Rect(400, 300, buttonWidth, buttonHeight), "+"))
        {

        }

        if (GUI.Button(new Rect(400, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "+"))
        {

        }

        if (GUI.Button(new Rect(400, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "+"))
        {

        }

        if (GUI.Button(new Rect(400, 300 + (buttonHeight + buttonMargin) * 3, buttonWidth, buttonHeight), "+"))
        {

        }

        if (GUI.Button(new Rect(400, 300 + (buttonHeight + buttonMargin) * 4, buttonWidth, buttonHeight), "+"))
        {

        }

        if (GUI.Button(new Rect(400, 300 + (buttonHeight + buttonMargin) * 5, buttonWidth, buttonHeight), "+"))
        {

        }
        if (GUI.Button(new Rect(400, 300 + (buttonHeight + buttonMargin) * 6, buttonWidth, buttonHeight), "+"))
        {

        }
        GUI.Label(new Rect(10, 310, 100, 20), "Strenght");
        GUI.Label(new Rect(10, 380, 100, 20), "Perception");
        GUI.Label(new Rect(10, 450, 100, 20), "Endurance");
        GUI.Label(new Rect(10, 520, 100, 20), "Charisma");
        GUI.Label(new Rect(10, 590, 100, 20), "Inteligence");
        GUI.Label(new Rect(10, 660, 100, 20), "Agility");
        GUI.Label(new Rect(10, 730, 100, 20), "Luck");

        GUI.Label(new Rect(100, 310, 100, 20 ), "=currentStreanght");

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
