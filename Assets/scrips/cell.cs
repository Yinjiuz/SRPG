using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell : MonoBehaviour
{
    private GameManager GameManager;
    public bool moveAble=false;
    public GameObject white;
    public GameObject red;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("this is a " + tag + " position:" + transform.position.x + "," + transform.position.y);
        if (moveAble==true)
        {
            GameManager.selected.gameObject.GetComponent<piece>().Move(transform.position.x, transform.position.y);
        }
    }
}
