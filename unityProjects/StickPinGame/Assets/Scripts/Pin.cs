using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        rd.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Rotator")
        {
            rd.velocity = Vector2.zero;
           // collider.GetComponent<Rotator>().speed += 10f;
            if(Random.Range(0f,1f) > 0.5f)
                collider.GetComponent<Rotator>().speed *= -1f;
            score.scoreValue++;
            transform.SetParent(collider.transform);
        }else if(collider.tag == "Pin")
        {
            GameObject.FindObjectOfType<GM>().GameOver();
        }
    }
}
