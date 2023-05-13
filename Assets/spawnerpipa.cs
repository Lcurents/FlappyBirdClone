using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerpipa : MonoBehaviour
{
    public GameObject pipas;
    public float spawnrate = 2;
    private float timer = 0;
    public float heigthOffSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipa();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipa();
            timer = 0;
        }
    }
    void spawnpipa()
    {
        float titikterendah = transform.position.y - heigthOffSet;
        float titiktertinggi = transform.position.y + heigthOffSet;
        Instantiate(pipas, new Vector3(transform.position.x,Random.Range(titikterendah,titiktertinggi),0), transform.rotation);

    }
}
