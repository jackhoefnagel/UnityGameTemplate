using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;

    void Awake(){
        instance = this;
    }

}
