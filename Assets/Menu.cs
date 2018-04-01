using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
public Texture GameLogo;
    public GUISkin skin;
    public float buttonWidth = 300;
public float buttonHeight = 60;

private float buttonMargin = 20;

    // Use this for initialization


    void OnGUI()
    {
        GUI.skin = skin;
        GUI.DrawTexture(new Rect(0, 0, 800, 300), GameLogo);

        if (GUI.Button(new Rect(300, 300, buttonWidth, buttonHeight), "New Game"))
        {
            Application.LoadLevel("New Game");
        }
        if (GUI.Button(new Rect(300, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "Options"))
        {

        }
        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "Exit"))
        {
            Application.Quit();
        }
      
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
