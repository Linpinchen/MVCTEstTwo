using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : IModel
{
    //private string playerName;
    private const string MenubuttonName = "Save";
    public event System.Func<string>  OutText;
    public event System.Action SetText;


    public Model(System.Func<string> getText, System.Action setText)
    {
        OutText = getText;
        SetText = setText;
    }

    //public string GetPlayerName()
    //{
    //    return playerName;
    //}

    //public void SetPlayerName(string name)
    //{
    //    playerName = name;
    //}
    public string GetMenuButtonName()
    {
        return MenubuttonName;
    }

    public string OutMenuTest()
    {
        return OutText();
    }

    public void SetMenuEvent()
    {
        SetText();
    }

}
