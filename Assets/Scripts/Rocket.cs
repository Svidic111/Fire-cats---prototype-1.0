using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private bool _isLaunched = false;
    [SerializeField]
    private bool _isFired = false;
    [SerializeField]
    private float _launchForce = 270;
    private int[] _rotationDir = { -1, 1 };
    [SerializeField]
    private int _randomIndex = 0;
    [SerializeField]
    private float _fireForce = 500;
    private Rigidbody2D _rb;
    private Vector2 _instPos;
    [SerializeField]
    private Spawn_Manager _spawnManager;
    private bool _hasCollide = false;
    public float AngularSpeed;
    private Level_1_UI _UIManager;


    void Start()
    {
        _spawnManager = FindObjectOfType<Spawn_Manager>();
        _rb = GetComponent<Rigidbody2D>();
        _instPos = transform.position;
        _UIManager = GameObject.Find("Canvas").GetComponent<Level_1_UI>();
    }


    void Update()
    {
        CheckPosition();
        Fire();

        AngularSpeed = _rb.angularVelocity;
    }


    private void CheckPosition()
    {
        if (transform.position.x <= -3.5f || transform.position.x >= 3.5f
            || transform.position.y <= -5.5f || transform.position.y >= 5.5f)
        {
            _spawnManager.newRocket(_instPos);
            _UIManager.WasteRocket();
            Destroy(this.gameObject);
        }
    }


    private void Fire()
    {
        if (Pause_Menu._isGamePaused == false && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > -3.5f)
        {

            if (_isLaunched == false && _isFired == false && Input.GetMouseButtonDown(0))
            {
                //Get the position of this object in screen-coordinates
                Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
                //You can calculate the direction from point A to point B using Vector3 dirAtoB = B - A;
                Vector3 dirToMouse = Input.mousePosition - posInScreen;
                //We normalize the direction (= make length of 1). This is to avoid the object moving with greater force when I click further away
                dirToMouse.Normalize();

                //Adding the force to the 2D Rigidbody, multiplied by forceAmount, which can be set in the Inspector
                _rb.AddForce(dirToMouse * _launchForce);

                _randomIndex = Random.Range(0, 2);

                _isLaunched = true;
                
                return;
            }

            if (_isLaunched == true && _isFired == false && Input.GetMouseButtonDown(0))
            {
                _rb.angularVelocity = 0;
                _rb.velocity = new Vector2(0, 0);
                _rb.AddForce(transform.up * _fireForce);
                _isFired = true;
            }
        }

        if (Pause_Menu._isGamePaused == false && _isLaunched == true && _isFired == false)
        {
            _rb.AddTorque(_rotationDir[_randomIndex] * 0.35f);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Ground" && _hasCollide == false)
        {
            _hasCollide = true;
            _spawnManager.newRocket(_instPos);
            _UIManager.WasteRocket();
            Destroy(this.gameObject);
        }

        if (other.tag == "Cloud" && _hasCollide == false)
        {
            _hasCollide = true;
            _spawnManager.newRocket(_instPos);
            _UIManager.WasteRocket();
            Destroy(this.gameObject);
        }
    }
}
