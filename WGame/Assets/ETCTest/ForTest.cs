using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ForTest : MonoBehaviour
{
    List<string> Objs = new List<string>();

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < Count.StringTestCount; i++)
            Objs.Add(i.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<Count.StringTestCount; i++)
        {
            string str = Objs[i];
        }
    }
}
