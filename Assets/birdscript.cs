using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D rigidtubuh;
    public float kepakan;
    public logicScript logic;
    public bool birdhidup = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true&&birdhidup)
        {
            rigidtubuh.velocity = Vector2.up * kepakan;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdhidup= false;
    }
}
