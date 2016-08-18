using UnityEngine;
using System.Collections;

public class MenuNavigator : MonoBehaviour {

    public GameObject MenuCanvas;
    public GameObject LevelSelectWorld1;

    // Use this for initialization

    public void OnClick()
    {
        MenuCanvas.SetActive(false);

        LevelSelectWorld1.SetActive(true);
    }
}
