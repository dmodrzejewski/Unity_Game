using UnityEngine;
using System.Collections;

public class Melee : MonoBehaviour
{

    public int min = 25;
    public int max = 50;
    public float weaponRange = 3f;

    public Camera myCamera;

    public TreeHealth treeHealth;
    public RockHealth rockHealth;
    public toInventory toInven;

    public void Update()
    {
        //create ray        have center of screen point to ray
        Ray center = myCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hitinfo;

        // if we left click 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          
            if (Physics.Raycast(center, out hitinfo, weaponRange))
            {
                // if we attack a tree execute AttackTree fn
                if (hitinfo.collider.tag == "Tree")
                {
                    treeHealth = hitinfo.collider.GetComponentInParent<TreeHealth>();
                    AttackTree();
                    
                }
                // if rock label call attackRock
                else if (hitinfo.collider.tag =="Rock")
                {
                    rockHealth = hitinfo.collider.GetComponent<RockHealth>();
                    AttackRock();
                }
            }
        }
    }

   
    public void AttackTree()
    {
        // randomizes damage between min and max int then deals damage to tree
        int damage = Random.Range(min, max);
        // takes damage and subtracts from current health
        treeHealth.health -= damage;
        toInven.toInv();

    }

    public void AttackRock()
    {
        // rng damage when hitting rock, same min max as tree at moment.
        int damage = Random.Range(min, max);
        rockHealth.rockHealth1 -= damage;
        toInven.toInv();
    }
}
