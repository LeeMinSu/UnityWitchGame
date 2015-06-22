using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class IEumeratorTest : MonoBehaviour
{

    List<string> objs = new List<string>();
    // Use this for initialization
    void Start()
    {
        for(int i = 0; i<Count.StringTestCount; i++)
        {
            objs.Add(i.ToString());
        }

    }

    // Update is called once per frame
    void Update()
    {

        IEnumerator iter = objs.GetEnumerator();
        while(iter.MoveNext())
        {
            string str = iter.Current.ToString();
        }

    }
}
