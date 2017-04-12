using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleClass : MonoBehaviour {
    public int myInt;
    public string myString;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CallFoo()
    {
        Debug.Log("Foo");
    }

    public void SetInt()
    {
        myInt = 10;
    }
}
