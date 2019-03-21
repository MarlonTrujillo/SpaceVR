using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameController : MonoBehaviour {

    public int points = 0;
    public AudioSource voice;
    public AudioSource click;
    public Rigidbody spaceshipRbd;
    public GameObject text;

    // Use this for initialization
    void Start () {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpherePlaced()
    {
        
        points++;
        Debug.Log(GameController.Instance.points);
        if (points == 3)
        {
            voice.volume = 0.4f;
            spaceshipRbd.DOMoveY(-0.09f , 3);
            text.SetActive(true);
        }

        else if (points == 1 )
        {
            spaceshipRbd.DOMoveY((15.09f / 4)*3, 3);
        }

        else if (points == 2 )
        {
            spaceshipRbd.DOMoveY((15.09f/4)*2 , 3);
        }
    }

    public void VoiceUp()
    {
        voice.volume = 0.4f;
    }
    
    public void VoiceDown()
    {
        voice.volume = 0.2f;
    }

    public void PlayClickSound()
    {
        click.Play();
    }
    #region Singleton

    // Implementacion del Singleton 
    private static GameController instance;
    private GameController() { }

    public static GameController Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("Matriz.Instance es nula pero se esta intentando accederla");
            }

            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            //Si soy la primera instancia, hacerme el Singleton
            instance = this;
            //Descomentar esta linea si el singleton debe persistir entre escenas
            //DontDestroyOnLoad(this);
        }
        else
        {
            //Si ya existe este singleton en la escena entonces destruir este objeto 
            if (this != instance)
                DestroyImmediate(gameObject);
        }
    }

    #endregion
}


