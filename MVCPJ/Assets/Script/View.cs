using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour,IView
{
    [SerializeField]
    private GameObject inputView;
    [SerializeField]
    private GameObject menuView;
    [SerializeField]
    private Button inputButton;
    [SerializeField]
    private Button menuButton;
    [SerializeField]
    private InputField input;
    [SerializeField]
    private InputField menu;

    private IController controller;

    public int i;

    void Start()
    {
        controller = new Controller(this, GetNoteText, SetNote);
        inputButton.onClick.AddListener(delegate {

            controller.InputEvent();

        });

        menuButton.onClick.AddListener(delegate
        {
            controller.MenuEvent();

	    });
    }

    public void SetMenu(string text)
    {
        menu.text = text;
    }


    //public string GetInputText()
    //{
    //    return input.text;
    //}

    public void SetMenubuttonText(string tetx)
    {
        inputView.SetActive(false);
        inputButton.gameObject.GetComponent<Text>().text = tetx;
    }

    //private string GetNoteText(string key)
    //{
    //    if (PlayerPrefs.HasKey(key))
    //    {
    //        return PlayerPrefs.GetString(key);
    //    }
    //    else
    //    {
    //        return "No Key";
    //    }

    //}

    //private void SetNote(string key)
    //{
    //    PlayerPrefs.SetString(key,menu.text);
    //    PlayerPrefs.Save();
    //}
    private string GetNoteText()
    {
        if (PlayerPrefs.HasKey(input.text))
        {
            return PlayerPrefs.GetString(input.text);
        }
        else
        {
            return "No Key";
        }

    }

    private void SetNote()
    {
        PlayerPrefs.SetString(input.text, menu.text);
        PlayerPrefs.Save();
    }


}
