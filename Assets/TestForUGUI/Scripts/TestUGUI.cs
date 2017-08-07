using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using UnityEngine.EventSystems;
using UnityScript;

public class TestUGUI : MonoBehaviour {

    [HideInInspector]
    public int userId{ get; set; }
    public Button btn;
    public InputField  _InputField;
    public Toggle _toggle;
    public ToggleGroup _toggleGroup;
	// Use this for initialization
	void Start () {
       // btn = GetComponent<Button>();
        //btn.onClick.AddListener(()=>OnClick(btn));
       // _InputField.onEndEdit.AddListener(TestFun);
        //_toggle.onValueChanged.AddListener((a)=>IsSelect(a,_toggle.name));
       
	}
    private void IsSelect(bool a,string toggle)
    {
        if (a)
        {
            print(toggle);
        }
            
 
    }

    public void TestFun(string arg0)
    {
        Debug.Log("OnSubmit注册方法被执行了");
        Debug.Log(arg0);
    }
    public void OnToggleChange(bool a)
    {
        print(a);
    }

    //private string OnInputSubmit(string fieldText)
    //{
    //    Debug.Log("OnSubmit注册方法被执行了");
    //    Debug.Log(_InputField.text);
    //    return null;
    //}


   // public void OnClick(Button sender)
    //{
    //    Debug.Log(string.Format("{0}:按键OnClick方法",sender.name));
    //    btn.onClick.RemoveAllListeners();
    //}

}
