using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class RockHealth : MonoBehaviour {

    public int rockHealth1 = 100;
    public toInventory toInven;

    public void Update()
    {
        // destroy rock if it has no health
        if (rockHealth1 <= 0)
        {
            Destroy(gameObject);
            toInven.toInv();

        }
    }
}
