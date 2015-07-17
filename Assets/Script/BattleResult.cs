//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;

//public class BattleResult : MonoBehaviour
//{
//    GameObject player1;
//    GameObject player2;

//    Player1Data player1Data;
//    Player2Data player2Data;

//    ArrayList actionPlayer1;
//    ArrayList actionPlayer2;

//    string player1Action;
//    string player2Action;

//    // Use this for initialization
//    void Awake()
//    {
//        player1 = GameObject.FindGameObjectWithTag("Player1Data");
//        player2 = GameObject.FindGameObjectWithTag("Player2Data");

//        player1Data = player1.GetComponent<Player1Data>();
//        player2Data = player2.GetComponent<Player2Data>();

//        actionPlayer1 = new ArrayList();
//        actionPlayer2 = new ArrayList();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        addAction();

//        checkAction();
//    }

//    void addAction()
//    {
//        if (Player1Data.curAction != "nothing")
//        {
//            actionPlayer1.Add(Player1Data.curAction);
//        }else if(Player2Data.curAction != "nothing"){
//            actionPlayer2.Add(Player2Data.curAction);
//        }
//    }

//    void checkAction()
//    {
//        if (actionPlayer1.Count > 1 && actionPlayer2.Count > 1)
//        {
//            player1Action = (string)actionPlayer1[0];
//            player2Action = (string)actionPlayer2[0];

//            if (player1Action == "attack" && player2Action == "bluff" || player1Action == "bluff" && player2Action == "defend")
//            {
//                Debug.Log(player1Action + " " + player2Action);
//                player2Data.TakeDamage(10, player1Action);
//            }
//            else if (player1Action == "bluff" && player2Action == "attack" || player1Action == "defend" && player2Action == "bluff")
//            {
//                Debug.Log(player1Action + " " + player2Action);
//                player1Data.TakeDamage(10, player2Action);
//            }
//            else if (player1Action == "attack" && player2Action == "attack" || player1Action == "bluff" && player2Action == "bluff")
//            {
//                Debug.Log(player1Action + " " + player2Action);
//                player1Data.TakeDamage(10, player2Action);
//                player2Data.TakeDamage(10, player1Action);
//            }
//            else
//            {
//                //resultText.text = "Nothing happen.";
//            }

//            actionPlayer1.RemoveAt(0);
//            actionPlayer2.RemoveAt(0);
//        }
//    }
//}
