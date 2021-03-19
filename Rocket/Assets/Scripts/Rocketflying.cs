using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketflying : MonoBehaviour
{
    public float rotSpeed;
    public float thrust;

    private Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, new Vector3(0, 0, 1), rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, new Vector3(0, 0, 1), -rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.position, new Vector3(1, 0, 0), rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(transform.position, new Vector3(1, 0, 0), -rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += (gameObject.GetComponent<Rigidbody>().velocity + ((transform.GetChild(5).transform.position - transform.position).normalized * thrust)) * Time.deltaTime;
        }
    }
}