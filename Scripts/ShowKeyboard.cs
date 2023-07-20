using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class ShowKeyboard : MonoBehaviour
{

    private TMP_InputField inputFild;
    // Start is called before the first frame update
    void Start()
    {
        inputFild = GetComponent<TMP_InputField>();
        inputFild.onSelect.AddListener(x => OpenKeybord());
        
    }

    // Update is called once per frame
    public void OpenKeybord()
    {
        NonNativeKeyboard.Instance.InputField = inputFild;
        NonNativeKeyboard.Instance.PresentKeyboard(inputFild.text);
            
            }
}
