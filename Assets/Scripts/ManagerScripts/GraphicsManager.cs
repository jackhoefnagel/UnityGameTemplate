using UnityEngine;
using System.Collections;

public class GraphicsManager : MonoBehaviour {

    public static GraphicsManager instance;

    void Awake(){
        instance = this;
    }
}
