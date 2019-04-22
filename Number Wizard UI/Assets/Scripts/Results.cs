using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Results : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI chosenNumber, attempts;

    // Start is called before the first frame update
    void Start()
    {
        chosenNumber.text = GameData.ChosenNumber.ToString();
        attempts.text = GameData.Attempts.ToString();
    }
}
