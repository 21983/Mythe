using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinGame : MonoBehaviour {

    //0 players = 1 player
    public int currentPlayers = 0;

    private GameObject[] selectP;
    private GameObject[] textJoin;

    [SerializeField] private GameObject _giveScripts;

    void Start()
    {

        textJoin = new GameObject[4];

        textJoin[0] = GameObject.Find("P1");
        textJoin[1] = GameObject.Find("PressJoin2");
        textJoin[2] = GameObject.Find("PressJoin3");
        textJoin[3] = GameObject.Find("PressJoin4");


        selectP = new GameObject[4];

        selectP[0] = GameObject.Find("P1");
        selectP[1] = GameObject.Find("SelectionP2");
        selectP[2] = GameObject.Find("SelectionP3");
        selectP[3] = GameObject.Find("SelectionP4");

        for (int j = 1; j < 4; j++)
        {
            selectP[j].SetActive(false);
        }
    }

    public void OnJoin()
    {
        Debug.Log("joining game");

        if(currentPlayers >= 3)
        {
            Debug.Log("Max players");
            currentPlayers = 3;
        }
        else
        {           
            currentPlayers += 1;
            selectP[currentPlayers].SetActive(true);
            textJoin[currentPlayers].SetActive(false);
        }
    }

    public void OnLeave()
    {
        Debug.Log("leaving game");

        if (currentPlayers <= 0)
        {
            Debug.Log("Min 1 player");
            currentPlayers = 0;
        }
        else
        {
            selectP[currentPlayers].SetActive(false);
            textJoin[currentPlayers].SetActive(true);
            currentPlayers -= 1;
        }
    }

    void Update()
    {
        Debug.Log("CurrentPlayers: " + currentPlayers);

        //im sry this is wrong to use here, i know, but i need it to work fast for now..
        _giveScripts.GetComponent<AddPlayers>().currentPlayers = currentPlayers + 1;
    }
}
