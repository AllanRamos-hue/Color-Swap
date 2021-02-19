using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    TrailRenderer trail;

   [HideInInspector] public SpriteRenderer sr;

    bool isDragging;
    
    public static bool hasScored25 = false;
    public static bool hasScored10 = false;

    [HideInInspector]
    public long score = 0;

    [HideInInspector]
    public long best = 0;

    Vector2 touchPosition;
    Vector2 playerPosition;
    Vector2 dragPosition;


    public Vector2 jumpSpeed;

    [Header("HUD")]
    public GameObject gameOverHUD;
    public GameObject pauseHUD;
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI bestScore;
    

    [Header("Colors")]
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

    public AudioClip ballKick;

    [Space]
    public UnityEvent onScoring25;

    [Space]
    public UnityEvent onScoring10;

    private MoveObjectGroup[] moveObjectGroup;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        trail = GetComponent<TrailRenderer>();
        
        moveObjectGroup = FindObjectsOfType<MoveObjectGroup>(); 

        ChangeColor();

        gameOverHUD.SetActive(false);

        Load();

        Application.targetFrameRate = 60;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SpriteRenderer enemySR = collision.gameObject.GetComponent<SpriteRenderer>();

        if (collision.gameObject.CompareTag("Jump"))
        {
           
            if (enemySR.color == sr.color)
            {
                collision.gameObject.SetActive(false);
                Score();
                Jump();
                ChangeColor();

                AudioManager.PlaySFX(ballKick);
            }
            else
            {
                Save();
                GameOver();
            }
        }   
    }

    void Update()
    {
        GetInput();
        MovePlayer();

        Camera.main.backgroundColor = sr.color / 2;

        if (score == 25)
        {
            hasScored25 = true;
            onScoring25.Invoke();
        }

        if(score == 10)
        {
            hasScored10 = true;
            onScoring10.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            DeleteSave();
        }

        currentScore.text = score.ToString();

        bestScore.text = "Best" + "\n" + best.ToString();

    }


    void GetInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            touchPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            playerPosition = transform.position;       
        }
        else if(Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    void MovePlayer()
    {
        if (isDragging)
        {
            dragPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            transform.position = new Vector2(playerPosition.x + (dragPosition.x - touchPosition.x), transform.position.y);

        }

        transform.Rotate(0, 0, 10);

        if (transform.position.x > 2.5)
        {
            transform.position = new Vector2(2.5f, transform.position.y);

        }

        if (transform.position.x < -2.5)
        {
            transform.position = new Vector2(-2.5f, transform.position.y);
        }
    }

    void GameOver()
    {
        for (int i = 0; i < moveObjectGroup.Length; i++)
        {
            moveObjectGroup[i].enabled = false;
        }
        
        gameObject.SetActive(false);

        gameOverHUD.SetActive(true);

        bestScore.gameObject.SetActive(true);

        StopAllCoroutines();

        AudioManager.StopBGS();
      
    }
   

    void Score()
    {
        score++;

        if (score > best)
        {
            best = score;
        }

    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(jumpSpeed, ForceMode2D.Impulse);
    }

    void ChangeColor()
    {
        int randomColor;

        randomColor = Random.Range(1, 3);

        if (hasScored10)
        {
            randomColor = Random.Range(1, 4);
        }

        if (hasScored25)
        {
            randomColor = Random.Range(1, 5);
        }

        if (randomColor == 1)
        {
            sr.color = color1;
            trail.startColor = color1;
            trail.endColor = color1;
        }

        else if (randomColor == 2)
        {
            trail.startColor = color2;
            trail.endColor = color2;
            sr.color = color2;
        }
            
        else if(randomColor == 3)
        {
            trail.startColor = color3;
            trail.endColor = color3;
            sr.color = color3;
        }

        else
        {
            trail.startColor = color4;
            trail.endColor = color4;
            sr.color = color4;
        }
    }

    public void Save()
    {
        SaveManager.SavePlayer(this);
    }

    public void Load()
    {
        PlayerData data = SaveManager.LoadScore();

        best = data.highscore;

    }

    public void DeleteSave()
    {
        SaveManager.DeleteSave();

        best = 0;
        score = 0;
    }

    public void PauseGame()
    {
        pauseHUD.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void ResumeGame()
    {
        pauseHUD.SetActive(false);
        Time.timeScale = 1f;
    }

    public void TurnOffDelay(GameObject gameObject)
    {
        StartCoroutine(DelayOnOff(gameObject, 3, true));
    }

    public void TurnOnDelay(GameObject gameObject)
    {
        StartCoroutine(DelayOnOff(gameObject, 0.8f, false));
    }


    IEnumerator DelayOnOff (GameObject gameObject, float time, bool active)
    {
        yield return new WaitForSeconds(time);

        if (active == true)
        {
            gameObject.SetActive(false);
        }
        else
            gameObject.SetActive(true);
        
    }
}
