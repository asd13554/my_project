using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Staff : MonoBehaviour
{
    public class Staff : MonoBehaviour
    {
        private int _id;
        public int ID { get { return _id; } set {_id = Int32.MaxValue;}}

        private int charSkinId;
        public int CharSkinID { get { return charSkinId;} set { charSkinId = value; } }
        public GameObject[] charSkin;
        
        public string staffName;
        public int dailyWage;

        public int InitCharID(int id)
        {
            _id = id;
            charSkinId = Random.Range(0, charSkin.Length - 1);
            staffName = "XXXX";
            dailyWage = Random.Range(80, 125)
        }

        public void ChangeCharSkin()
        {
            for (int i = 0; i < charSkin; i++)
            {
                
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
