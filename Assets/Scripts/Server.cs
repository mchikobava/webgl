using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

public class Server : MonoBehaviour
{
    NetworkServerSimple server = null;
    //UnityWebRequest webRequest

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Init()
    {
        NetworkTransport.Init();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
