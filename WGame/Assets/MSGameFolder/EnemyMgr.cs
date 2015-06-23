using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMgr : MonoBehaviour {

   public delegate void ColliderCompleteCallBack(Transform trans);

    new Transform[] EnemyTransform = new Transform[5];   
    public  ColliderCompleteCallBack CompleteCallback = null;
    UIMgr _UIMgr;
   
    // Use this for initialization

	void Start () {
          CompleteCallback = CompleteCol;
           GameObject[] Temps =  GameObject.FindGameObjectsWithTag("Enemy");
            for(int i = 0; i<Temps.Length; i++)
            {
                EnemyTransform[i] = Temps[i].transform;
            }
            _UIMgr = FindObjectOfType<UIMgr>();
	}
	
	// Update is called once per frame
	void Update () {
        for(int i = 0; i<5; i++)
        {
            EnemyTransform[i].Translate(Vector3.left * Time.deltaTime);
            if( EnemyTransform[i].localPosition.x <= -512.0f )
            {
                if (CompleteCallback == null)
                {
                    Debug.Log("Not SetCompleteCallback");
                    return;
                }

                MoveEnemy(EnemyTransform[i]);
            }
        }
	}

    void CompleteCol(Transform trans)
    {
        MoveEnemy(trans);
        _UIMgr.SetUiAfterPumCollider();
    }
    void MoveEnemy(Transform trans)
    {
        trans.localPosition = new Vector3(512.0f, Random.Range(-300, 300), 0.0f);
    }

}
