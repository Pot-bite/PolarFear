using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TemperatureBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxValue(int dgrs)
    {
        slider.maxValue = dgrs;
        slider.value = dgrs;
        fill.color = gradient.Evaluate(1f);
    }

    public void SetValue(int dgrs)
    {
        slider.value = dgrs;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
