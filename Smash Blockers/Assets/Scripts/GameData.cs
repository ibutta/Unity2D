using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{

    [Range(0, 3f)]
    [SerializeField]
    float gameSpeed;

    [SerializeField]
    TextMeshProUGUI scoreOutput;

    //private int _gameScore = 0;
    private int _instanceCount;

    private void Awake()
    {
        _instanceCount = FindObjectsOfType<GameData>().Length;
        if(_instanceCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            GameScore = 0;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = gameSpeed;
        scoreOutput.text = GameScore.ToString();
        //_gameScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = gameSpeed;
        //scoreOutput.text = GameScore.ToString();
    }

    public void AddPoints(int points)
    {
        GameScore += points;
        scoreOutput.text = GameScore.ToString();
    }

    public int GameScore { get; private set; }

    public void ResetGameData()
    {
        Destroy(gameObject);
    }
}
