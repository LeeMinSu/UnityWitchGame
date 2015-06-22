using UnityEngine;
using System.Collections;

public class IterTestScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.gameObject.AddComponent<ForeachTest>();
        this.gameObject.AddComponent<ForTest>();
        this.gameObject.AddComponent<IEumeratorTest>();
    }


}
