using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SliderInteraction : MonoBehaviour
{
    public TextMeshProUGUI sliderValueText;

	public Slider slider;

	public void Start()
	{
		sliderValueText.text = slider.value.ToString();

		//Adds a listener to the main slider and invokes a method when the value changes.
		slider.onValueChanged.AddListener(OnSliderValueChanged);
	}

	public void OnSliderValueChanged(float value)
	{
		sliderValueText.text = "Slider Value: " + value;
	}

	

	

}
