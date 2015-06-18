using UnityEngine;
using System.Collections;

public class BG_Move : MonoBehaviour {

    public Camera NGUICamera;
    new Transform transform;

	// Use this for initialization
	void Start () {
        transform = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {

        if (NGUICamera == null)
            return;
        transform.Translate(Vector3.left * Time.deltaTime);
        Vector3 Position = NGUICamera.WorldToViewportPoint(this.gameObject.transform.position);
        Debug.Log(Position.x);
        if (Position.x <= -2678.0f)
        {
            this.gameObject.transform.position = new Vector3(-512.0f, 0.0f,0.0f);
        }
	}
}
