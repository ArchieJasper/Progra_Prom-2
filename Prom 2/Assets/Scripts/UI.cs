using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UI : MonoBehaviour
{
    static UI instance;
    [SerializeField]
    public int score; 

    [SerializeField] 
    TextMeshProUGUI scoreText;


    void Awake()
    {
        UpdateScore();
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreText.text = "Puntos: " + score;
    }

    public static UI GetInstance()
    {
        return instance;
    }
}
