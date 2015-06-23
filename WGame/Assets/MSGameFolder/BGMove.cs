using UnityEngine;
using System.Collections;

public class BGMove : MonoBehaviour {

    new Transform _transform;

	// Use this for initialization
	void Start () {

        _transform = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        _transform.Translate( Vector3.left * Time.deltaTime );
        if( _transform.localPosition.x <= -2048.0f )
        {
            _transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        }
	}
}
