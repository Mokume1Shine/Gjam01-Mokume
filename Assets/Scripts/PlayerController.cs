using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public float speedLimit=5;
    public float accele=0.1f;
    public float nAccele = 0.05f;
    private Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start(){
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        float h, v;
        h=Input.GetAxis("Horizontal");
        v=Input.GetAxis("Vertical");
        Vector2 vel=rb.velocity;
        vel.x=Accele(h,vel.x);
        vel.y=Accele(v,vel.y);
        if(vel.magnitude>speedLimit) {
            float rad = Mathf.Atan2(vel.y,vel.x);
            vel.x=speedLimit*Mathf.Cos(rad);
            vel.y=speedLimit*Mathf.Sin(rad);
        }
        Debug.Log(vel.magnitude+","+Mathf.Atan2(vel.y,vel.y));
        rb.velocity=vel;
    }

    private float Accele(float input,float value) {
        if(input<0) value-=accele;
        else if(input>0) value+=accele;
        else {
            if(value>0) value-=nAccele;
            if(value<0) value+=nAccele;
            if(value>-nAccele&&value<=nAccele) value=0;
        }
        return value;
    }
}
