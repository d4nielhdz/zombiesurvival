﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerMovement : MonoBehaviour {
    [SerializeField]
    private float speed = 0.0005f;
    public AudioSource audioData;
    private void Awake () {

    }
    // Start is called before the first frame update
    void Start () {
        // audioData = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {
        float yPos = transform.position.y;
        float translation = Input.GetAxis ("Vertical");
        float lowerLimit = 4.07f;
        float upperLimit = 9.90f;

        if (Input.GetKey (KeyCode.Space)) {
            audioData.Play (0);
        }

        if (yPos <= upperLimit && yPos >= lowerLimit) {
            transform.Translate (new Vector2 (0, translation));
        } else if (yPos >= upperLimit && Input.GetKey (KeyCode.DownArrow)) {
            transform.Translate (new Vector2 (0, translation));
        } else if (yPos <= lowerLimit && Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (new Vector2 (0, translation));
        }
    }

}
// // Al presionar W quiero incrementar Y
// if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
// {
//     //this.transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
//     transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
// }
// // Al presionar S quiero decrementar Y
// if (Input.GetKey(KeyCode.S))
// {
//     // this.transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
//     transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
// }
// // Al presionar D quiero incrementar X
// if (Input.GetKey(KeyCode.D))
// {
//     // this.transform.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
//     transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
// }
// // Al presionar A quiero decrementar X
// if (Input.GetKey(KeyCode.A))
// {
//     // this.transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
//     transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

// }