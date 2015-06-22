using UnityEngine;
using System.Collections;

public class UpdaterTest : MonoBehaviour {

    public bool Term = false;
    private bool IsStartCor = false;
	// Use this for initialization
	void Start () {
	
	}
	
    private IEnumerator TermTime()
    {
        while(true)
        {
            if (Term == false)
                break;

            yield return new WaitForSeconds(3.0f);
            Debug.Log("Term Log");
        }
        IsStartCor = false;
    }
	// Update is called once per frame
	void Update () {

        if( false == Term )
        { 
            Debug.Log("TTTTT");
        }
        else
        {
            if (true == IsStartCor)
                return;
            IsStartCor = true;
            StartCoroutine("TermTime");
        }
	}
}
