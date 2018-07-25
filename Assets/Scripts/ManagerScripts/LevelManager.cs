using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    void Awake(){
        instance = this;
    }
}
