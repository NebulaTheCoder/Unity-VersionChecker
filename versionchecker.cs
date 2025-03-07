using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Collections;

public class VersionChecker : MonoBehaviour
{
    [Header("fully coded by .apkmethod on discord")]
    [SerializeField] private string versionURL;
    [SerializeField] private string redirectScene;
    
    void Start()
    {
        StartCoroutine(CheckVersion());
    }
    
    IEnumerator CheckVersion()
    {
        UnityWebRequest request = UnityWebRequest.Get(versionURL);
        yield return request.SendWebRequest();
        
        if (request.result == UnityWebRequest.Result.Success)
        {
            string correctVersion = request.downloadHandler.text.Trim();
            string gameVersion = Application.version;
            
            if (gameVersion != correctVersion)
            {
                SceneManager.LoadScene(redirectScene);
            }
        }
    }
}
