using UnityEngine;
using System.Collections;

public class UIMgr : MonoBehaviour {

    public const int TotalGetPum = 127;
    public int CurGetPum = 0;
    UISprite _ScoreBar;
	void Start () {
        GameObject [] obj= GameObject.FindGameObjectsWithTag("ScoreBar");
        _ScoreBar = obj[0].GetComponent<UISprite>();
        int a = 0;

	}
	
	// Update is called once per frame
	public void Update () {
	
	}

    public void SetUiAfterPumCollider()
    {
        ++CurGetPum;
        Debug.Log(CurGetPum);
        _ScoreBar.fillAmount = CurGetPum  * 0.008f; 
    }
}
