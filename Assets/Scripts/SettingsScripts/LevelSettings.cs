using UnityEngine;
using System.Collections;

public class LevelSettings : MonoBehaviour {

    public static LevelSettings instance;

    void Awake(){
        
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
