using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public PaddleScript paddle;
    Vector3 paddleBallPosDiff;
    bool gameStart = false;

	// Use this for initialization
	void Start () {
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
}
