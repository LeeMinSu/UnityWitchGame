
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ForeachTest : MonoBehaviour
{
    private List<string> Obj = new List<string>();
    void Start()
    {
        for(int i = 0; i< Count.StringTestCount; i++)
            Obj.Add(i.ToString());
    }
    void Update()
    {
        foreach(string st in Obj )
        {
            string Str = st;
        }
    }

}
