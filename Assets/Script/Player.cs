using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    CharacterController charaControll;
    Animation anim;

    float normalSpeed = 3f; // �ʏ�ړ����x
    float sprintSpeed = 6f; // �_�b�V���ړ����x
    float jump = 7f;        // �W�����v��
    float gravity = 10f;    // �d�͂̑傫��

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
