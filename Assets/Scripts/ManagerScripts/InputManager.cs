using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public static InputManager instance;

    void Awake(){
        instance = this;
    }
}
