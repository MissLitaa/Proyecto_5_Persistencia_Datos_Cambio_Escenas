using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerMenu : MonoBehaviour
{
    public static UIManagerMenu sharedInstance;
    public TMP_InputField inputField;
  
    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
           
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        string existingUserName = PlayerPrefs.GetString("USER_NAME");
        if (existingUserName != "")
        {
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
    }

    public void SaveUsername()
    {
        //hacer placeholders de texto

        string userName = inputField.text;

        if (userName == "")
        {
            DataPersistance.sharedInstance.userName = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }

        else
        {
            DataPersistance.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("USER_NAME", DataPersistance.sharedInstance.userName);
    }
}
