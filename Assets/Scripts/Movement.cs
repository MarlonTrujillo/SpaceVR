using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}


	public void ApplyChange(bool gazedAt){

		if (gazedAt == true) {
            GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Impulse);
            GameController.Instance.VoiceUp();
        }
        else {
            if (GameController.Instance.points < 3)
            {
                GameController.Instance.VoiceDown();
            }
            
        }
	}
}
