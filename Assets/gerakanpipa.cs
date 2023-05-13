using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakanpipa : MonoBehaviour
{
    public float movespeed = 4;
    public float deadZone = -22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+(Vector3.left * movespeed)*Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipa terhapus");
            Destroy(gameObject);
        }
    }
}
