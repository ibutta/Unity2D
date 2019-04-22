using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{

    static int attempts, chosenNumber;

    public static int Attempts
    {
        get
        {
            return attempts;
        }

        set
        {
            attempts = value;
        }
    }

    public static int ChosenNumber
    {
        get
        {
            return chosenNumber;
        }

        set
        {
            chosenNumber = value;
        }
    }

}
