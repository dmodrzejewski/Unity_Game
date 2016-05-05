using UnityEngine;
using System.Collections;

public class TreeHealth : MonoBehaviour {

        // tree health is 100
        public int health = 100;

        public void Update()
        {
            // destroy tree if it has no health
            if (health <= 0)
            {
                //Destroy object your hitting if health is under 0
                Destroy(gameObject);
            
            }
        }
    }
