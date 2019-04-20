using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public Object[] characters;

    public int contestant1Index;
    public int contestant2Index;
    public int contestant3Index;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        
        characters = Resources.LoadAll("Prefabs/Characters") as Object[];
        
        FindContestants();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindContestants()
    {
        contestant1Index = Random.Range(0, characters.Length); //TODO change to canonical partner of selected bachelor/bachelorete
        contestant2Index = Random.Range(0, characters.Length);
        contestant3Index = Random.Range(0, characters.Length);

        if (contestant1Index == contestant2Index || contestant1Index == contestant3Index || contestant2Index == contestant3Index)
        {
            FindContestants();
        }
        else
        {
            var currentContestant1 = characters[contestant1Index];
            var currentContestant2 = characters[contestant2Index];
            var currentContestant3 = characters[contestant3Index];

            Instantiate(currentContestant1, new Vector3(1.5f, 0, 0), Quaternion.identity);
            Instantiate(currentContestant2, new Vector3(4, 0, 0), Quaternion.identity);
            Instantiate(currentContestant3, new Vector3(6.5f, 0, 0), Quaternion.identity);
            
            
        }
    }
    
}
