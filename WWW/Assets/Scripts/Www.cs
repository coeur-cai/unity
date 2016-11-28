using UnityEngine;
using System.Collections;

public class Www : MonoBehaviour {

    //本地贴图
    Texture localImage;
    //服务器端贴图
    Texture serverImage;

    //加载本地贴图
    IEnumerator localLoad() 
    {
        if (localImage==null)
        {
            WWW local = new WWW("file://"+Application.dataPath + "/Images/1.jpg");
            yield return local;
            localImage = local.texture;
        }
        gameObject.GetComponent<Renderer>().material.mainTexture = localImage;

    //加载本地服务器端贴图
    }
    IEnumerator serverLoad() 
    {
        if (serverImage==null)
        {
            WWW server = new WWW("http://localhost/Images/2.jpg");
            yield return server;
            serverImage = server.texture;
        }
        gameObject.GetComponent<Renderer>().material.mainTexture = serverImage;
    }
    void OnGUI() 
    {
        if (GUILayout.Button("点击切换本地贴图"))
        {
            StartCoroutine(localLoad());
        }
        if (GUILayout.Button("点击切换服务器贴图"))
        {
            StartCoroutine(serverLoad());
        }
    }
}
