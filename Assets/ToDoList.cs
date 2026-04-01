using System;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour
{
    public int numlines = 0;
    public GameObject item;
    public Transform big;
    public GameObject popup;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numlines = 0;
        popup.SetActive(false);
        item.SetActive(false);
        
    }

    public void Add()
    {
        popup.SetActive(true);
    }
    
    public void AddTask()
    {
        numlines++;
        popup.SetActive(false);
    }

    public void UpdateItem()
    {
        Instantiate(item, big);
    }

    public void Reset()
    { 
        foreach(Transform Child in big)
        {
            if(Child.CompareTag("clone"))
            {
                Destroy(Child.gameObject);
            }
        }
        numlines = 0;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
