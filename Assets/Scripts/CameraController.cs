using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

    public GameObject player;//Camera Target
    private Rigidbody2D playerRigidbody;
    public float velSense=5.0f;

    // Start is called before the first frame update
    void Start(){
        playerRigidbody=player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate(){
        Vector3 playerPos = player.transform.position;
        /*Vector3 playerVel;
        playerVel= (Vector3)playerRigidbody.velocity;
        Vector2 pvel = playerRigidbody.velocity;
        if(pvel.magnitude>player.GetComponent<PlayerController>().speedLimit/2.0f){
            float rad = Mathf.Atan2(pvel.y,pvel.x);
            playerVel=new Vector3(velSense*Mathf.Cos(rad),velSense*Mathf.Sin(rad),0);
        } else {
            playerVel=new Vector3(0,0,0);
        }*/
        Vector3 cameraOffset = new Vector3(0,0,-10f);
        /*Vector3 targetPos;
        targetPos = playerPos+playerVel/velSense+cameraOffset;*/
        //targetPos=playerPos+playerVel*2+cameraOffset;
        //https://unity-yuji.xyz/player-follow-camera-smoothness/
        //transform.position=Vector3.Lerp(transform.position,targetPos,3.0f*Time.deltaTime);
        transform.position=playerPos+cameraOffset;
    }
}