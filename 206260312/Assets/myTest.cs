using UnityEngine;

public class myTest : MonoBehaviour
{
    public string playerName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerName = "123";
        Debug.Log("Hello Wolrd" + playerName);
       // Debug.LogError("Hello Wolrd");
       // Debug.LogWarning("Hello Wolrd");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
