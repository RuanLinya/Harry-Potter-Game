using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class HandController : MonoBehaviour
{   // Add GripInputAction and TriggerInputAction
    [SerializeReference] InputActionReference GripInputAction;
    [SerializeReference] InputActionReference TriggerInputAction;
    Animator HandAnimator;
    private void Awake()
    {
        // Get HandAnimation
        HandAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        GripInputAction.action.performed += GripPressed;
        TriggerInputAction.action.performed += TriggerPressed;
    }
    private void GripPressed(InputAction.CallbackContext obj)
    {
        HandAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        HandAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void OnDisable()
    {
        GripInputAction.action.performed -= GripPressed;
        TriggerInputAction.action.performed -= TriggerPressed;
    }
}
