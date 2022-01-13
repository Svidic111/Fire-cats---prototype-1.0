using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_1_UI : MonoBehaviour
{
    [SerializeField]
    private Text _scoreValue;
    private int _currentScore;

    void Start() {
        _scoreValue.text = "0";
    }

    
    void Update() {
        
    }

    public void UpdateScore(int score) {
        _currentScore += score;
        _scoreValue.text = _currentScore.ToString();
    }
}
