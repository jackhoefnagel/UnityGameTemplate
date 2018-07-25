using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

    public static CameraManager instance;

    void Awake(){
        instance = this;
    }
}
