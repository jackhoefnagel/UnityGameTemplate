using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    void Awake(){
        instance = this;
    }
}
