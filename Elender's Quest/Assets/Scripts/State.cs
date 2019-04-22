using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,10)]
    [SerializeField]
    string storyText;

    [SerializeField]
    State[] gameStates;

    public string GetStoryText()
    {
        return storyText;
    }

    public State[] GetLinkedStates()
    {
        return gameStates;
    }

}
