using UnityEngine;

public class Main : MonoBehaviour
{
 private Rect rect = new Rect(0f, 0f, Screen.width , Screen.height);

    void OnGUI()
    {
        GUI.skin.label.fontSize = 40; 
        GUI.Label(rect, "Hello Jenkins");
        Debug.Log(34);
        Debug.Log(34);
        Debug.Log(34);
    }

}