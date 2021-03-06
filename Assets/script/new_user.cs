using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class new_user : MonoBehaviour
{
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void SubmitName(string arg0)
    {
        PlayerPrefs.SetString("name", arg0);
        PlayerPrefs.Save();
        mainplay.Global.playerName = arg0;
        //load mainmap
        SceneManager.LoadScene(sceneName: "Story");
    }
}
