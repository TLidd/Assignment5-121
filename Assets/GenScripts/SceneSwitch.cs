﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("IS Not");
        if(Input.GetKeyDown("space")){
            //Debug.Log("IS DOWN");
            SceneManager.LoadScene("Scene1");
        }
    }
}
