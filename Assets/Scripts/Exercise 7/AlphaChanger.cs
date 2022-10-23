using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaChanger : MonoBehaviour
{
    public Material sphereMat;

    private Color color;

    private void Start()
    {
        color = sphereMat.color;
    }

    public void AlphaValueChanger(float f)
    {
        color.a = f;
    }
}