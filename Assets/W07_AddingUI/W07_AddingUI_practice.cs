using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W07_AddingUI_practice : MonoBehaviour
{
    public Slider slider;
    public GameObject objectToControl;
    Vector3 DefaultPos;
    Quaternion DefaultRot;

    private void Start()
    {
        DefaultPos = objectToControl.transform.localPosition;
        DefaultRot = objectToControl.transform.rotation;
    }

    public void OnSlide_Rotate() {
        float sliderValue = slider.value;
        print(sliderValue);
        objectToControl.transform.rotation = Quaternion.Euler(0, sliderValue*360f , 0); //Slider value는 0~1, 회전은 360도까지 되므로 360 곱하기
    }

    public void OnClick_MoveLeft() {
        print("Move Left");
        objectToControl.transform.Translate(Vector3.left * 0.1f);
    }
    public void OnClick_MoveRight()
    {
        print("Move Right");
        objectToControl.transform.Translate(Vector3.right * 0.1f);
    }

    public void OnClick_DefaultPos() {

        print("DefaultPos");
        objectToControl.transform.position = DefaultPos;
    }

    public void OnClick_DefaultRot()
    {
        objectToControl.transform.rotation = DefaultRot;
        slider.value = 0.0f;
    }

     public void OnClick_SetActive(bool active) {

        print("Set Active");
        objectToControl.SetActive(active);
    }
}
