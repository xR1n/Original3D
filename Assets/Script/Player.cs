using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Animation anim;
    public CharacterController characterControll;

    public float normalSpeed = 3f; // 通常移動速度
    public float sprintSpeed = 6f; // ダッシュ移動速度
    public float jump = 7f;        // ジャンプ力
    public float gravity = 10f;    // 重力の大きさ

    Vector3 moveDirection = Vector3.zero;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        characterControll = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 移動入力取得
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        characterControll.Move(moveDirection * normalSpeed * Time.deltaTime);

        //// キャラクターの回転
        //if(moveDirection !=Vector3.zero)
        //{
        //    Quaternion targetRotation = Quaternion.LookRotation(move);

        //}
    }
}
