using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //public GameObject block;


    public float speed = 2.5f;



    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(block,new Vector3(-1.55f, 4.75f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(transform.position.y);

        if (transform.position.y > -1.08f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        }
        else
        {
            
        }
    }

    void Fall()
    {

    }

    void CreateBlocks()
    {

    }
}
