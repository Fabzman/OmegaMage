using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementInventoryButton : MonoBehaviour {

    public ElementType type;

    private void Awake()
    {
        char c = gameObject.name[0];
        string s = c.ToString();
        int typeNum = int.Parse(s);

        type = (ElementType)typeNum;
    }

    void OnMouseUpAsButton()
    {
        Mage.S.SelectElement(type);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
