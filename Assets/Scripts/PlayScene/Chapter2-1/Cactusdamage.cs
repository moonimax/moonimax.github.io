using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactusdamage : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().TakeDamage(5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
