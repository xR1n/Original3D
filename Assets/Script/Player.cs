using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Animation anim;
    public CharacterController characterControll;

    public float normalSpeed = 3f; // �ʏ�ړ����x
    public float sprintSpeed = 6f; // �_�b�V���ړ����x
    public float jump = 7f;        // �W�����v��
    public float gravity = 10f;    // �d�͂̑傫��

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
        // �ړ����͎擾
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        characterControll.Move(moveDirection * normalSpeed * Time.deltaTime);

        //// �L�����N�^�[�̉�]
        //if(moveDirection !=Vector3.zero)
        //{
        //    Quaternion targetRotation = Quaternion.LookRotation(move);

        //}
    }
}
