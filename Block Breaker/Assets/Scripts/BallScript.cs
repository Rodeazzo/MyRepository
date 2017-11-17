using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    PaddleScript paddle;
    Vector3 paddleBallPosDiff;
    bool gameStart = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<PaddleScript>();

        paddleBallPosDiff = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (!gameStart) {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart) {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameStart) {
            GetComponent<AudioSource>().Play();
        }
    }
}
