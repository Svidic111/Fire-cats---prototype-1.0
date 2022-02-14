using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_1 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.2f;
    private Level_1_UI _UIManager;
    // [SerializeField]
    // private int _cloudValue;

    void Start() {
    //   _cloudValue = 30;

      _UIManager = GameObject.Find("Canvas").GetComponent<Level_1_UI>();  
    }

    void Update() {
        CheckPosition();
        Float();
    }

    private void CheckPosition() {
        if (transform.position.x <= -4f || transform.position.x >= 4f) {
            
            Destroy(this.gameObject);
        }
    }

    private void Float() {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // _UIManager.UpdateScore(_cloudValue);
        Destroy(this.gameObject);
    }

}
