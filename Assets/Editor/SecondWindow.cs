using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SecondWindow : EditorWindow
{
    private SampleClass sClass;

    public static SecondWindow ShowWindow()
    {
        SecondWindow sw = GetWindow<SecondWindow>();
        return sw;
    }

    public void setSample(SampleClass sc)
    {
        sClass = sc;
    }

    private void OnGUI()
    {
        if(sClass!=null)
        {
            sClass.myInt = EditorGUILayout.IntField(sClass.myInt);
            sClass.myString = EditorGUILayout.TextField(sClass.myString);
        }
    }

}
