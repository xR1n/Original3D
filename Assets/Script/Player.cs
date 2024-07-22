using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    CharacterController charaControll;
    Animation anim;

    float normalSpeed = 3f; // 通常移動速度
    float sprintSpeed = 6f; // ダッシュ移動速度
    float jump = 7f;        // ジャンプ力
    float gravity = 10f;    // 重力の大きさ

    Vector3 moveDirection = Vector3.zero;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
