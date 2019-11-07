using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoP : MonoBehaviour {

    [Header("對話")]
    public string Say = "嗨，你好，我快沒電了，可以請你幫我找到五顆電池？";
    public float Speed = 0.2f;
    [Header("任務相關")]
    public bool Complete = false;
    public int BateryFinush = 5;
    public int Batery = 0;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
