using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MainWindow : EditorWindow
{
    public SampleClass mySample;
    public SampleClass mySample2;
    public SecondWindow mySWindow;
    [MenuItem("Window/NodeWindow")]
    public static void ShowWindow()
    {
        GetWindow<MainWindow>();
    }
     void OnGUI()
    {
        mySample = (SampleClass)EditorGUILayout.ObjectField(mySample, typeof(SampleClass), true);
        if (mySample != null)
        {
            if (GUILayout.Button("Edit"))
            {
                mySWindow = SecondWindow.ShowWindow();
                mySWindow.setSample(mySample);
            }
        }


        mySample2 = (SampleClass)EditorGUILayout.ObjectField(mySample2, typeof(SampleClass), true);
        if (mySample2 != null)
        {
            if (GUILayout.Button("Edit"))
            {
                mySWindow = SecondWindow.ShowWindow();
                mySWindow.setSample(mySample2);
            }
        }
    }
}

