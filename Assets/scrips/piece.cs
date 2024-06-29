using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour
{
    public int damage;
    public int armor;
    public int healthMax;
    public int health;

    public int moveRange;
    public int attackRange;

    public int playerNumber;
    private GameManager GameManager;

    public bool beAttackedAble=false;
    // Start is called before the first frame update
    void Start()
    {
        health = healthMax;
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (beAttackedAble == false)
        {
            Debug.Log("this is a " + tag + " position:" + transform.position.x + "," + transform.position.y);
            GameManager.selected = gameObject;
            GameManager.showMoveRange();
            GameManager.showAttackRange();
        }
        else
        {
            health -= GameManager.selected.GetComponent<piece>().damage;
            GameManager.closeShowAttackRange();
        }
    }
    public void attack()
    {

    }
    public void Move(float x,float y)
    {
        transform.position = new Vector3(x, y,transform.position.z);
        GameManager.closeShowMoveRange();
        GameManager.closeShowAttackRange();
    }
}
