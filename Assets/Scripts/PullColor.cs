using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;


public class PullColor : MonoBehaviour
{
    public Material green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick()
    {
        Debug.Log("onClick");
        StartCoroutine(ColorOnRequest("https://669a3785-9e91-4232-965f-118bc9bb0f6b.mock.pstmn.io/color"));


    }

    // changes color to the color pulled from the server
    private IEnumerator ColorOnRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            GameObject cube = GameObject.Find("Cube");
            if (webRequest.downloadHandler.text == "green")
            {
                cube.GetComponent<MeshRenderer>().material = green;
            }
        }
    }
}
