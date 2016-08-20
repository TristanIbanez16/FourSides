using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.ImageEffects;

public class LevelChanger : MonoBehaviour
{

    public string levelGrade;

    public string Level;

    string gradeValue;

    [Header("Audio")]

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip finishLevel;

    [Header("Grade Times")]

    public float ATimeRange;
    public float BTimeRange;
    public float CTimeRange;
    public float DTimeRange;

    Camera MainCamera;
    BlurOptimized blurEffect;

    public Canvas canvas;

    public GameObject APlusCanvas;
    public GameObject ACanvas;
    public GameObject BCanvas;
    public GameObject CCanvas;
    public GameObject DCanvas;

    float timeStop;

    Timer timer;

    Player playerController;
    PauseMenu Pause;


    private bool SpaceBarPressed = false;
    bool levelComplete = false;

    void Start()
    {

        playerAudio = GetComponent<AudioSource>();
        Pause = GameObject.Find("Game Manager").GetComponent<PauseMenu>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        timer = GameObject.Find("Time").GetComponent<Timer>();
        MainCamera = GameObject.Find("Game Camera").GetComponent<Camera>();
        blurEffect = MainCamera.GetComponent<BlurOptimized>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && levelComplete == true)
        {
            StartCoroutine("ChangeLevel");
        }
        else
        {
            return;
        }
        timer.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerAudio.clip = finishLevel;
            playerAudio.Play();

            Pause.enabled = false;
            StartCoroutine("ChangeLevelCo");
        }
    }

    public void OnClick()
    {
        StartCoroutine("ChangeLevelCo");
    }

    public IEnumerator ChangeLevelCo()
    {
        levelComplete = true;
        timer.enabled = false;
        yield return new WaitForSeconds(0.6f);
        playerController.enabled = false;
        //canvas.enabled = false;
        Time.timeScale = 0f;

        if (Timer.timer <= ATimeRange && LevelManager.playerDeaths == 0)
        {
            gradeValue = "A+";

            blurEffect.enabled = true;
            Instantiate(APlusCanvas, transform.position, transform.rotation);

            PlayerPrefs.SetString(levelGrade, gradeValue);
        }

        if (Timer.timer <= ATimeRange && LevelManager.playerDeaths == 1)
        {
            gradeValue = "A";

            blurEffect.enabled = true;
            Instantiate(ACanvas, transform.position, transform.rotation);

            PlayerPrefs.SetString(levelGrade, gradeValue);
        }

        if (Timer.timer >= ATimeRange && Timer.timer <= BTimeRange - 0.1f)
        {
            gradeValue = "B";

            blurEffect.enabled = true;
            Instantiate(BCanvas, transform.position, transform.rotation);

            PlayerPrefs.SetString(levelGrade, gradeValue);
        }

        if (Timer.timer >= BTimeRange && Timer.timer <= CTimeRange - 0.1f)
        {
            gradeValue = "C";

            blurEffect.enabled = true;
            Instantiate(CCanvas, transform.position, transform.rotation);

            PlayerPrefs.SetString(levelGrade, gradeValue);
        }

        if (Timer.timer >= CTimeRange)
        {
            gradeValue = "D";

            blurEffect.enabled = true;
            Instantiate(DCanvas, transform.position, transform.rotation);

            PlayerPrefs.SetString(levelGrade, gradeValue);
        }

        if (SpaceBarPressed == true)
        {
            yield return new WaitForSeconds(0.6f);
            float fadeTime = GameObject.Find("Game Manager").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene(Level);
        }

    }
    public IEnumerator ChangeLevel()
    {

        Time.timeScale = 1f;
        timer.enabled = false;
        yield return new WaitForSeconds(0.1f);
        float fadeTime = GameObject.Find("Game Manager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);

        SceneManager.LoadScene(Level);

    }
}


