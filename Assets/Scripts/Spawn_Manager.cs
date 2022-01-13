using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    [SerializeField]
    private Rocket _rocketPrefab;
    [SerializeField]
    private Cloud_1 _cloud_1;
    [SerializeField]
    private Cloud_2 _cloud_2;
    [SerializeField]
    private Cloud_3 _cloud_3;


    void Start() {
        Instantiate<Rocket>(_rocketPrefab, new Vector2(0.1f, -3.3f), Quaternion.identity);
        StartCoroutine(Cloud1Spawn());
        StartCoroutine(Cloud2Spawn());
        StartCoroutine(Cloud3Spawn());
    }


    void Update() {
        
    }


    public void newRocket(Vector2 pos) {
        Instantiate<Rocket>(_rocketPrefab, pos, Quaternion.identity);
    }


    private IEnumerator Cloud1Spawn() {
        while (true) {
            Instantiate(_cloud_1, new Vector2(-3.8f, 4.5f), Quaternion.identity);
            yield return new WaitForSeconds(4.3f);
        }
    }


    private IEnumerator Cloud2Spawn() {
        while (true) {
            Instantiate(_cloud_2, new Vector2(-3.8f, 4f), Quaternion.identity);
            yield return new WaitForSeconds(3.14f);
        }
    }


    private IEnumerator Cloud3Spawn() {
        while (true) {
            Instantiate(_cloud_3, new Vector2(-3.8f, 3.55f), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }
}
