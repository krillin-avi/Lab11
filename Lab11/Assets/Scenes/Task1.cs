using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // List of Players
    List<string> PlayerList = new List<string>();

    // Queue to be used
    Queue<string> PlayerQueue = new Queue<string>();

    // Check for if Queue is empty
    bool ShouldRepeat = true;


    void Start()
    {
        // Populate List
        PlayerList.Add("Christian E");
        PlayerList.Add("Andrew T");
        PlayerList.Add("Adriana F");
        PlayerList.Add("Kaui S");
        PlayerList.Add("Mikey C");

        PlayerList.Add("Ryah M");
        PlayerList.Add("Leo M");
        PlayerList.Add("Galo D");
        PlayerList.Add("Shy F");
        PlayerList.Add("Kobe N");

        PlayerList.Add("Jack L");
        PlayerList.Add("Kayla R");
        PlayerList.Add("Matt A");
        PlayerList.Add("Gideon S");
        PlayerList.Add("Peter S");

        PlayerList.Add("Nathan S");
        PlayerList.Add("Alex B");
        PlayerList.Add("Kevin L");
        PlayerList.Add("Griffen B");
        PlayerList.Add("Lebron J");


        PopulateQueue();
        LoginPlayer();
        InvokeRepeating("LoginPlayer", 2, 4);
      
    }

    
    void PopulateQueue() 
    {
        // Create Initial PlayerQueue and Return how many players are inside of the queue
        // Populating each player 'p' inside of the list with the Enqueue method
        foreach (string p in PlayerList)
        {
            PlayerQueue.Enqueue(p);
        }

        int count = PlayerQueue.Count;

        Debug.Log("Initial login queue created. There are " + count + " players in the queue:");
    }

    void LoginPlayer()
    {
        // Check if queue is empty
        if (PlayerQueue.Count > 0)
        {
            // Get the next player in queue and log them in
            string NextPlayer = PlayerQueue.Peek();
            Debug.Log(NextPlayer + " is now inside the game.");
            PlayerQueue.Dequeue();

            if (PlayerQueue.Count > 0)
            {
                Debug.Log(PlayerQueue.Peek() + " is trying to login and added to the login queue.");
            }
        }
        else
        {
            ShouldRepeat = false; 
        }

        // Check if ShouldRepeat is false, then cancel InvokeRepeating
        if (!ShouldRepeat)
        {
            CancelInvoke("LoginPlayer");
            Debug.Log("Queue is empty.");
        }
    }


}
