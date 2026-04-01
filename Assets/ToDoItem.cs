using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToDoItem : MonoBehaviour
{
    private TMP_Text inputField;
    //public GameObject input; 
    public Toggle checkbox;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
        
    }

public void Strike(bool isOn)
{
        inputField = GetComponentInChildren<TMP_Text>();
    if (isOn)
    {
        inputField.fontStyle = FontStyles.Strikethrough;
        Debug.Log("strike status:" + isOn);

    } else {
        inputField.fontStyle = FontStyles.Normal;  
        Debug.Log("strike status:" + isOn);
  
      
    }
    

    
}


    // Update is called once per frame
    void Update()
    {
        
    }
}


