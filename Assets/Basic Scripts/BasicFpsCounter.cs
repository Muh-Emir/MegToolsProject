using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFpsCounter : MonoBehaviour
{
    float deltaTime = 0.0f;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.01f;
    }

    private void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.normal.textColor = Color.white;
        style.fontSize = h * 2 / 100;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{1:0.} fps ({0:0.0}ms)", msec, fps);
        GUI.Label(rect, text, style);
    }
}