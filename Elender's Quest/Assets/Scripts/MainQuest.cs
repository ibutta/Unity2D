using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainQuest : MonoBehaviour
{

    [SerializeField]
    Text mainTextComponent;
    [SerializeField]
    State initialState;

    State currentState;
    bool stateChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        currentState = initialState;
        mainTextComponent.text = currentState.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {

        if (stateChanged)
        {
            mainTextComponent.text = currentState.GetStoryText();
        }

    }

    private void OnGUI()
    {
        if(Event.current.isKey && 
            Event.current.type.Equals(EventType.KeyDown))
        {
            ManageStates(Event.current.keyCode);
        }
    }

    private void ManageStates(KeyCode key)
    {
        State[] possibleStates = currentState.GetLinkedStates();
        try
        {
            switch (key)
            {
                case KeyCode.Return:
                    Debug.Log("ENTER");
                    if (currentState.Equals(initialState))
                    {
                        currentState = possibleStates[0];
                        stateChanged = true;
                    }
                    break;
                default:
                    for(int i = 0; i < possibleStates.Length; i++)
                    {
                        if(key == (KeyCode.Alpha1 + i) ||
                            key == (KeyCode.Keypad1 + i))
                        {
                            currentState = possibleStates[i];
                            stateChanged = true;
                        }
                    }
                    Debug.Log(key);
                    break;
            }
        }
        catch (IndexOutOfRangeException) { }

    }
}
