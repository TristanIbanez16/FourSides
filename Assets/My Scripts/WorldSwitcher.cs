using UnityEngine;
using System.Collections;

public class WorldSwitcher : MonoBehaviour {

    public GameObject WorldCanvasRemover;
    public GameObject LevelSelectWorld;

    // Use this for initialization

    public void OnClick()
    {
        WorldCanvasRemover.SetActive(false);

        LevelSelectWorld.SetActive(true);
    }
}
