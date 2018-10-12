using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemy
{
    Vector3 pos { get; set; }
    float touchDamage { get; set; }
    string typeString { get; set; }

    GameObject gameObject { get; }
    Transform transform { get; }
}

//public class Enemy : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
		
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}
//}
