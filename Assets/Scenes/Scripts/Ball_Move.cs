using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement; //SCHENE KÜTÜPHANESÝ
using TMPro;

public class Ball_ : MonoBehaviour
{
    public float jumppower;
    public Rigidbody2D Ball;

    public Color turkuazRenk, sariRenk, morRenk, pembeRenk;
    public string havecolor;
    public SpriteRenderer painter;

    public Transform Round;
    public Transform ColorSwitch;
    public Transform Clone;

    public Transform Clone2;
    public Transform Round2;

    public TextMeshProUGUI ScoreText;
    public int score;

    public AudioSource Jump;

    void Start()
    {
        switchcolor();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball.velocity=Vector2.up*jumppower;

            Jump.Play();
        }

        ScoreText.text = "Score:" + score;


    }

    void switchcolor()
    {
        int rastgele = Random.Range(0, 4);

        switch (rastgele)
        {
            case 0:
                havecolor = "Turkuaz";
                painter.color = turkuazRenk;
                break;
            case 1:
                havecolor = "Sari";
                painter.color = sariRenk;
                break;
            case 2:
                havecolor = "Mor";
                painter.color = morRenk;
                break;
            case 3:
                havecolor = "Pembe";
                painter.color = pembeRenk;
                break;
        
        }
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.tag != havecolor && temas.tag !="RenkDegistirici" && temas.tag != "Clone" && temas.tag !="Clone2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(temas.tag == "RenkDegistirici" )
        {
            switchcolor();

            ColorSwitch.position=new Vector3(ColorSwitch.position.x,ColorSwitch.position.y+7f,ColorSwitch.position.z);
            score++;

        }

        if(temas.tag == "Clone")
        {
            Round.position = new Vector3(Round.position.x, Round.position.y + 14f, Round.position.z);
            Clone.position=new Vector3(Clone.position.x,Clone.position.y+14f,Clone.position.z);
        }
        if(temas.tag == "Clone2")
        {
            Round2.position=new Vector3(Round2.position.x,Round2.position.y + 14f,Round2.position.z);
            Clone2.position=new Vector3(Clone2.position.x,Clone2.position.y +14f,Clone2.position.z); 
        }
    }
}
