using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public float damage = 50.0F;
    public float attackDuration = 0.3F;

    public bool attacking = false;


    [HideInInspector]


    void Start()
    {

    }

    void Update()
    {


        if (Input.GetKeyDown("h"))
        {
            attacking = true;
        }
    }

    void OnCollisionEnter(Collision myCol)
    {
        Collider col = myCol.collider;

        Debug.Log("damage object collider");
        if (col.tag == "joejeff")
        {
            if (attacking)
            {
                Debug.Log("we are sending damage");
                col.SendMessage("receiveDamage", damage, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    void EnableDamage()
    {
        if (attacking == true) return;
        attacking = true;
        StartCoroutine("DisableDamage");
    }

    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        attacking = false;
    }
}
