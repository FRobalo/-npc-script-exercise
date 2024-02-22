using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 10;
        int level = 5;
        health += level;
        print(health); //look in console to check health

        
    }

    // Update is called once per frame
    void Update()
    {
        int speed = 5; 
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
