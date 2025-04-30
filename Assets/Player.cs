using UnityEngine;
using System;

public class Player : MonoBehaviour
{
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
