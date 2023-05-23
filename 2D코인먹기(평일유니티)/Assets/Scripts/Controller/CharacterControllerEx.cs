using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerEx : MonoBehaviour
{
    [SerializeField, Range(0, 20),Header("이동속도 변수")]
    int _moveSpeed = 0;

    [SerializeField, Range(0, 20),Tooltip("점프속도 변수입니다.")]
    int _jumpSpeed = 0;

    bool isGround = false;
    public bool IsGround { get => isGround; set => isGround = value; }

    

    Rigidbody2D _rigid = null;
    Animator _anim = null;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //transform.position +=
        //    new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime, 0);
        //if (Input.GetKey(KeyCode.RightArrow))
        //    _rigid.AddForce(Vector2.right * _moveSpeed,ForceMode2D.Impulse);
        //if(Input.GetKey(KeyCode.LeftArrow))
        //    _rigid.AddForce(Vector2.left * _moveSpeed, ForceMode2D.Impulse);

        if (!isGround)
        {
            _anim.Play("Jump");
        }

        if (!Input.anyKey && isGround)
        {
            _anim.Play("Idle");
            _rigid.velocity = new Vector2(0, _rigid.velocity.y);
            return;
        }

        Movement();
        Jump();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow) && isGround)
        {
            _anim.Play("Run");
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.Translate(Vector2.right * _moveSpeed * Time.deltaTime);
            _rigid.AddForce(Vector2.right * _moveSpeed, ForceMode2D.Impulse);
            _rigid.velocity = new Vector2(_moveSpeed, _rigid.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && isGround)
        {
            _anim.Play("Run");
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _rigid.AddForce(Vector2.left * _moveSpeed, ForceMode2D.Impulse);
            _rigid.velocity = new Vector2(-_moveSpeed, _rigid.velocity.y);
            //transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround)
        { 
            _rigid.AddForce(Vector2.up * _jumpSpeed,ForceMode2D.Impulse);
            //Vector2.up == new Vector2(0,1)
        }
    }


}
