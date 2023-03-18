using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;
    
    public static GameManager instance;
    
    void Start()
    {
        GenerateCandidate();
    }
    void Update()
    {
        
    }

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();
            
            s.InitCharID(i);
            s.ChangeCharSkin();
        }
    }
}
