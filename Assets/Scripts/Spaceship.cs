using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spaceship : MonoBehaviour {

    private Rigidbody rbd;

	// Use this for initialization
	void Start () {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
