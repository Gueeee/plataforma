using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Quadrado") {
            Time.timeScale = 0f;
            Debug.Log("Game Over.");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mvspd = 5f;

        float x_dir = 0f;

        x_dir = (Convert.ToSingle(Input.GetKey(KeyCode.RightArrow))-Convert.ToSingle(Input.GetKey(KeyCode.LeftArrow)));

        transform.position += new Vector3(x_dir,0f,0f) * mvspd * Time.deltaTime;
    }
}
