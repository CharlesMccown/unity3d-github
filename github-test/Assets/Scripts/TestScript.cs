using UnityEngine;

public class TestScript : MonoBehaviour {
    private Color color = new Color(0, 1, 0);
    private void Awake()
    {
        string welcomeMessage = $"<color=\"{color.ToRGBHex()}\">Welcome to the GitHub test project.</color>";
        Debug.Log(welcomeMessage);
    }
}
