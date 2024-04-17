using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W07_AddingUI : MonoBehaviour
{
    public Slider slider;
    public GameObject ObjectToControl;
    Vector3 DefaultPos;
    Quaternion DefaultRot;

    private void Start()
    {
        DefaultPos = ObjectToControl.transform.localPosition;
        DefaultRot = ObjectToControl.transform.localRotation;
    }
    public void OnSlide_Rotate()
    {
        float sliderValue = slider.value;
        print(sliderValue);
        ObjectToControl.transform.rotation = Quaternion.Euler(0, sliderValue * 360, 0);
    }

    public void OnClick_MoveLeft()
    {
        ObjectToControl.transform.Translate(Vector3.left * 0.1f);
    }

    public void OnClick_MoveRight()
    {
        ObjectToControl.transform.Translate(Vector3.right * 0.1f);
    }

    public void OnClick_SetActive(bool _active)
    {
        ObjectToControl.SetActive(_active);
    }

    public void OnClick_DefaultPos()
    {
        ObjectToControl.transform.localPosition = DefaultPos;
    }

    public void OnClick_DefaultRot()
    {
        ObjectToControl.transform.rotation = DefaultRot;
        slider.value = 0;
    }
}
