using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : IController
{
    private IView view;
    private IModel model;

    public Controller(IView view, System.Func<string> getText, System.Action setText)
    {
        this.view = view;
        model = new Model(getText, setText);
    }

    public void InputEvent()
    {
        //model.SetPlayerName(view.GetInputText());
        view.SetMenubuttonText(model.GetMenuButtonName());
        view.SetMenu(model.OutMenuTest());
    }

    public void MenuEvent()
    {
        model.SetMenuEvent();
    }
}
