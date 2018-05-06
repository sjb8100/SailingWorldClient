﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KBEngine;
using System;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour {

    public InputField textID;
    public InputField textPassword;
    public Text message;

    public GameObject login;
    public GameObject NameSet;
	// Use this for initialization
	void Start () {
        string path = Application.streamingAssetsPath;
        if (path.Contains("copy"))
        {
            textID.text = "222";
            textPassword.text = "222";

        }
        else
        {
            textID.text = "111";
            textPassword.text = "111";
        }
        KBEngine.Event.registerOut("onLoginFailed", this, "onLoginFailed");
        KBEngine.Event.registerOut("onLoginSuccessfully", this, "onLoginSuccessfully");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onLogin()
    {
        KBEngine.Event.fireIn("login", textID.text, textPassword.text, System.Text.Encoding.UTF8.GetBytes("PC"));
    }

    public void onLoginSuccessfully()
    {
        Debug.LogFormat("登录成功！");
        message.text = ("登录成功！");
        Account me = KBEngineApp.app.player() as Account;
        //Data.accountNama = me.Name;
        login.SetActive(false);
        NameSet.SetActive(me.Name == string.Empty);

    }

    public void onLoginFailed(UInt16 failID)
    {
        Debug.LogErrorFormat("登录失败，错误码：{0},原因：{1}", failID, KBEngineApp.app.serverErr(failID));
        message.text = string.Format("登录失败，错误码：{0},原因：{1}", failID, KBEngineApp.app.serverErr(failID));
    }
}