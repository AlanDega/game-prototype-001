using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2 : MonoBehaviour
{
    //public GameObject block;


    public float speed = 2.5f;
    public float waitingTime = 2f;
    public bool isUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(block,new Vector3(-1.55f, 4.75f, 0f), Quaternion.identity);
        StartCoroutine("LockBlock");
    }

    // Update is called once per frame
    void Update()
    {

        if (isUnlocked == true && transform.position.y > -1.91f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {

        }

    }

    IEnumerator LockBlock()
    {
        yield return new WaitForSeconds(waitingTime);
        isUnlocked = true;
    }




}
