using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShoot : MonoBehaviour
{
    public GameObject shoot;
    public GameObject character;
    Animator anim;
    Animator charAnim;
    // Start is called before the first frame update
    void Start()
    {
        anim = shoot.GetComponent<Animator>();
        charAnim = character.GetComponent<Animator>();
    }
    public void SetShootTrigger()
    {
        anim.SetTrigger("Shoot");
    }

    //Cài đặt phương thức dùng để hiển thị sprite khi chạy vào đúng event
    public void VisibleObj()
    {
        shoot.GetComponent<SpriteRenderer>().enabled = true;
    }

    //Cài đặt phương thức dùng để tắt hiển thị sprite khi chạy xong event
    public void InvisibleObj()
    {
        shoot.GetComponent<SpriteRenderer>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            charAnim.SetTrigger("Shoot");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            charAnim.SetFloat("JumpSpeed", 4f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            charAnim.SetFloat("Speed", 4f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            charAnim.SetFloat("Speed", 4f);
        }
        else
        {
            charAnim.SetFloat("Speed", 0f);
            charAnim.SetFloat("JumpSpeed", 0f);
        }
       
        
    }
    private void FixedUpdate()
    {

    }
}
