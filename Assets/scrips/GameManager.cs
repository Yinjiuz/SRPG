using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] cells;
    public GameObject[] blocks;
    public GameObject[] pieces;
    public GameObject selected;
    private List<GameObject> moveList;
    private List<GameObject> attackList;
    private List<GameObject> beAttackList;
    void Start()
    {
        cells = GameObject.FindGameObjectsWithTag("cell");
        moveList = new List<GameObject>();
        attackList = new List<GameObject>();
        beAttackList = new List<GameObject>();
    }

    void Update()
    {
        
    }
    public void showMoveRange()
    {
        foreach(var cell in cells)
        {
            if (Mathf.Abs(cell.transform.position.x - selected.transform.position.x) +
                Mathf.Abs(cell.transform.position.y - selected.transform.position.y) <= selected.GetComponent<piece>().moveRange)
            {
                cell.GetComponent<cell>().white.SetActive(true);
                cell.GetComponent<cell>().moveAble = true;
                moveList.Add(cell);
            }
        }
    }
    public void showAttackRange()
    {
        foreach (var cell in cells)
        {
            if (Mathf.Abs(cell.transform.position.x - selected.transform.position.x) +
                Mathf.Abs(cell.transform.position.y - selected.transform.position.y) <= selected.GetComponent<piece>().attackRange)
            {
                cell.GetComponent<cell>().red.SetActive(true);
                attackList.Add(cell);
            }
        }
        foreach (var piece in pieces)
        {
            if (Mathf.Abs(piece.transform.position.x - selected.transform.position.x) +
                Mathf.Abs(piece.transform.position.y - selected.transform.position.y) <= selected.GetComponent<piece>().attackRange)
            {
                piece.GetComponent<piece>().beAttackedAble = true;
                beAttackList.Add(piece);
            }
        }
    }
    public void closeShowMoveRange()
    {
        foreach (var cell in moveList)
        {
            cell.GetComponent<cell>().white.SetActive(false);
            cell.GetComponent<cell>().moveAble = false;
        }
        moveList = new List<GameObject>();
    }
    public void closeShowAttackRange()
    {
        foreach (var cell in attackList)
        {
            cell.GetComponent<cell>().red.SetActive(false);
        }
        foreach (var piece in beAttackList)
        {
            piece.GetComponent<piece>().beAttackedAble = false;
        }
        attackList = new List<GameObject>();
        beAttackList = new List<GameObject>();
    }
}
