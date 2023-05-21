using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharacter : MonoBehaviour
{
    //he añadido al pj: rigidbody y collider
    float moveInput;
    float velMov = 4;

    //Animator anim;
    Rigidbody2D rb;
    private void Awake()
    {
        //anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
    }    
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(moveInput * velMov, rb.velocity.y, 0);
        //MovimientoAnim();


        //meter un raycast -> cuando esté frente a la puerta > texto>pulsa E para entrar>input.E>scenemanager
        //RaycastHit2D hit;
        //Ray ray;
        //if (Physics.Raycast(ray, out hit))
        //{
        //
        //}
        
    }







    //animacion y giro del personaje:

    //private void MovimientoAnim()
    //{
    //    if (moveInput != 0)
    //    {
    //        anim.SetBool("movimiento", true);
    //        Flip();
    //    }
    //    else
    //    {
    //        anim.SetBool("movimiento", false);
    //    }
    //}
    //private void Flip()
    //{
    //    if (moveInput > 0)
    //    {
    //        this.transform.localScale = new Vector3(1, 1, 1);
    //    }
    //    if (moveInput < 0)
    //    {
    //        this.transform.localScale = new Vector3(-1, 1, 1);
    //    }
    //}
}
