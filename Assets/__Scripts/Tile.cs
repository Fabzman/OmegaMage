using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : PT_MonoBehaviour {

    public string type;

    private string _tex;
    private int _height = 0;
    private Vector3 _pos;

        public int height
    {
        get { return (_height); }
        set {
            _height = value;
            AdjustHeight();
        }
    }

    public string tex
    {
        get { return (_tex); }
        set
        {
            _tex = value;
            name = "tileprefab_" + _tex;
            Texture2D t2D = LayoutTiles.S.GetTileTex(_tex);
            if (t2D == null)
            {
                Utils.tr("error", "tile.type{set}=", value, "no matching texture2d in layouttiles.s.tiletextures!");
            }

            else
            {
                GetComponent<Renderer>().material.mainTexture = t2D;
                //renderer.material.maintexture = t2d;
            }
        }
    }

    new public Vector3 pos
    {
        get { return (_pos); }
        set {
            _pos = value;
            AdjustHeight();
        }
    }

    public void AdjustHeight()
    {
        Vector3 vertOffset = Vector3.back * (_height - 0.5f);
        transform.position = pos + vertOffset;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
