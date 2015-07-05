using UnityEngine;
using System.Collections;

public class UIMgr : MonoBehaviour {

    public const int TotalGetPum = 20;
    public int CurGetPum = 0;
    delegate void GameComplete();
    private GameComplete CallbackCompleteGame;
    UISprite _ScoreBar;
    public TweenPosition Result;

	void Start () {
        CallbackCompleteGame = OnEndGame;
        GameObject [] obj= GameObject.FindGameObjectsWithTag("ScoreBar");
        _ScoreBar = obj[0].GetComponent<UISprite>();
	}
    private void OnEndGame()
    {
        Result.gameObject.SetActive(true);
        Result.ResetToBeginning();
        Time.timeScale = 0.0f;

    }
	
	// Update is called once per frame
	public void Update () {
	
	}

    public void SetUiAfterPumCollider()
    {
        ++CurGetPum;
        Debug.Log(CurGetPum);
        _ScoreBar.fillAmount = CurGetPum  * 0.05f; 
        //if( CurGetPum == 200 )
        //{
        //    CallbackCompleteGame();
        //}
    }
}
