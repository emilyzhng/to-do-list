using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class updatedsystem : MonoBehaviour
{

    public TMP_InputField taskname;
    public TMP_InputField catagory;
    public Transform big;
    public GameObject item;
    public TMP_Text placeholder; 
    public TMP_Dropdown dropdownMenu;
    String input;
    String cat;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        dropdownMenu.ClearOptions();
        TMP_Dropdown.OptionData placeholder = new TMP_Dropdown.OptionData("select category");
        dropdownMenu.options.Add(placeholder);
        dropdownMenu.RefreshShownValue();

        TMP_Dropdown.OptionData showall = new TMP_Dropdown.OptionData("show all");
        dropdownMenu.options.Add(showall);
        dropdownMenu.RefreshShownValue();
    }

    public void Settask()
    {
        input = taskname.text;
        cat = catagory.text;
        GameObject newItem = Instantiate(item, big); 
        newItem.GetComponentInChildren<TMP_Text>().text = input;
        newItem.AddComponent<categoryscript>().catagory = cat;
        newItem.SetActive(true);
    
    }

    public void AddOption()
    {
        String input = catagory.text;
        foreach (TMP_Dropdown.OptionData o in dropdownMenu.options)
    {
        if (o.text == input)
            {
                return; 
            }
    }
            
    
        TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
        option.text = input;
        dropdownMenu.options.Add(option); 
        dropdownMenu.RefreshShownValue(); 
    }

    public void Sorttask()
    {
        string selected = dropdownMenu.options[dropdownMenu.value].text;

        if(selected == "select category") 
        {
            return;
        }

        if(selected == "show all") 
        {
            foreach(Transform Child in big)
            {
                Child.gameObject.SetActive(true);
            }
            return;
                
        }
        
        foreach(Transform Child in big)
        {
            categoryscript cat = Child.GetComponent<categoryscript>();

        if (cat == null)
            {
             continue;   
            }

        if(cat.catagory == selected)
        {
            Child.gameObject.SetActive(true);
        } else
        {
            Child.gameObject.SetActive(false);
        }
        }
    }

    public void Resettasks()
    {
        dropdownMenu.ClearOptions();
        TMP_Dropdown.OptionData placeholder = new TMP_Dropdown.OptionData("select category");
        dropdownMenu.options.Add(placeholder);
        dropdownMenu.RefreshShownValue();

        TMP_Dropdown.OptionData showall = new TMP_Dropdown.OptionData("show all");
        dropdownMenu.options.Add(showall);
        dropdownMenu.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
