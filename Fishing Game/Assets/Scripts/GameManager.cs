using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSourse;

    int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager Instance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        audioSourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score: " + score;
        audioSourse.Play();
    }

}