using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class co2bar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxValue(int persents)
    {
        slider.maxValue = persents;
        slider.value = persents;
        fill.color = gradient.Evaluate(1f);
    }

    public void SetValue(int persents)
    {
        slider.value = persents;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
