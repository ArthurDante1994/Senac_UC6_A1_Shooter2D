using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    public float MoveSpeed = 2f;
    public float RotationSpeed = 5f;
    private bool jump = false;

    private Vector3 gravidade;
    private CharacterController cc;
    public Transform floorCollidor;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moviment = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;

        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));

        //cc.Move(moviment);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        if (!cc.isGrounded)
        {
            gravidade += Physics.gravity * Time.deltaTime;
        }
        else
        {
            gravidade = Vector3.zero;
            if (jump && floorCollidor.GetComponent<FloorCollidor>().canJump == true){
                //anim.SetTrigger("Pula");
                floorCollidor.GetComponent<FloorCollidor>().canJump = false;
                gravidade.y = 10f;
                jump = false;
            }
        }
        moviment += gravidade;

        cc.Move(moviment* Time.deltaTime);
        if (moviment.x != 0)
        {
            if (floorCollidor.GetComponent<FloorCollidor>().canJump == true)
            {
                anim.SetTrigger("Corre");
                //Debug.Log("esta Correndo " + moviment.x);
            }
            else
            {
                anim.SetTrigger("Pula");
            }
        }
        else
        {
            if (floorCollidor.GetComponent<FloorCollidor>().canJump == true)
            {
                anim.SetTrigger("Parado");
                //Debug.Log("esta parado " + moviment.x);
            }
            else
            {
                anim.SetTrigger("Pula");
            }
        }
    }
}
