using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cube : MonoBehaviour{

    public GameObject Cube;
    public Vector3 movementAmountup;
    public Vector3 movementAmountdown;
    public Vector3 movementAmountleft;
    public Vector3 movementAmountright;

    // Use this for initialization
    void Start()
    {
        movementAmountup = new Vector3(-1, 0, 0);
        movementAmountdown = new Vector3(1, 0, 0);
        movementAmountleft = new Vector3(0, 0, -1);
        movementAmountright = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W)) {
            Cube.transform.position += movementAmountup;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            Cube.transform.position += movementAmountdown;
        }
        if (Input.GetKeyDown(KeyCode.A)){
            Cube.transform.position += movementAmountleft;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            Cube.transform.position += movementAmountright;
        }
    }
}