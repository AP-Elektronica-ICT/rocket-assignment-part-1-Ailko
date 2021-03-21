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
            gameObject.GetComponent<Rigidbody>().angularVelocity += new Vector3(0, 0, rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().angularVelocity += new Vector3(0, 0, -rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody>().angularVelocity += new Vector3(rotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody>().angularVelocity += new Vector3(-rotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().velocity += ((transform.GetChild(5).transform.position - transform.position).normalized * thrust) * Time.deltaTime;
        }
    }
}