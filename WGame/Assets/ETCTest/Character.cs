using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
    EnemyMgr _mgr;
	void Start () {

        _mgr = FindObjectOfType<EnemyMgr>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (_mgr == null || _mgr.CompleteCallback == null)
        {
            Debug.Log("Not SetCompleteCallback By Trigger");
            return;
        }
        _mgr.CompleteCallback(other.transform);

    }


}
