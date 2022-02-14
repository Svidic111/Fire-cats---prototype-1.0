using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level_1_UI : MonoBehaviour
{
    [SerializeField]
    private  TextMeshProUGUI _rocketsNumber;
    private int _rocketsAmount = 10;
    [SerializeField]
    private Pause_Menu _pauseMenu;

    void Start() {
        _rocketsNumber.text = _rocketsAmount.ToString();
    }

    
    void Update() {
        if (_rocketsAmount == 0) {
            _pauseMenu.LevelEndMenu();
            _rocketsAmount--;
        }
    }

    public void WasteRocket() {
        _rocketsAmount--;
        _rocketsNumber.text = _rocketsAmount.ToString(); 
    }
}
