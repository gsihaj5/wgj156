using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairHandler : MonoBehaviour
{
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
        Vector3 velocity = this.gameObject.transform.parent.GetComponent<Rigidbody2D>().velocity;
        
        //if(angle % 90 == 0 && (movement.x != 0 || movement.y != 0))
        if(velocity.x != 0 || velocity.y != 0)
            transform.eulerAngles = new Vector3(0,0,angle);
    }
}
