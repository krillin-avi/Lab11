using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // List of Players
    List<string> PlayerList = new List<string>();

    // For Random Numbers
    System.Random RandomNumber = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        // Populate List
        PlayerList.Add("Christian");
        PlayerList.Add("Andrew");
        PlayerList.Add("Adriana");
        PlayerList.Add("Kaui");
        PlayerList.Add("Mikey");

        PlayerList.Add("Ryah");
        PlayerList.Add("Leo");
        PlayerList.Add("Galo");
        PlayerList.Add("Shy");
        PlayerList.Add("Kobe");

        PlayerList.Add("Jack");
        PlayerList.Add("Kayla");
        PlayerList.Add("Matt");
        PlayerList.Add("Gideon");
        PlayerList.Add("Peter");

        PlayerList.Add("Nathan");
        PlayerList.Add("Alex");
        PlayerList.Add("Kevin");
        PlayerList.Add("Griffen");
        PlayerList.Add("Lebron");

        // Create Array for 15 Names
        string[] RandomArray = new string[15];

        HashSet<string> RandomHash = new HashSet<string>();
        HashSet<string> DuplicateHash = new HashSet<string>();


        for (int i = 0; i < RandomArray.Length; i++)
        {
            // Getting random index of list that is within the range out PlayerList
            int RandomIndex = RandomNumber.Next(PlayerList.Count);

            // Gets the string at RandomIndex
            string RandomName = PlayerList[RandomIndex];

            // Adds RandomName to RandomArray
            RandomArray[i] = RandomName;

            // Adds RandomName to RandomHash and if its already inside, its added to DuplicateHash 
            if (!RandomHash.Add(RandomName))
            {
                DuplicateHash.Add(RandomName);
            }

        }

        // Returns any Duplicated Names
        if (DuplicateHash.Count > 0) 
        {
            Debug.Log("Duplicate names found:");
            foreach (string name in DuplicateHash)
            {
                Debug.Log(name);
            }
        }
        else
        {
            Debug.Log("No Duplicates found.");
        }

    }
  
}
