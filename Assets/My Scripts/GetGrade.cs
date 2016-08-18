using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetGrade : MonoBehaviour {

    private Text gradeText;

    public string LevelGrade;

    // Use this for initialization
    void Start ()
    {
        gradeText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        gradeText.text = (PlayerPrefs.GetString(LevelGrade));
	}
}
