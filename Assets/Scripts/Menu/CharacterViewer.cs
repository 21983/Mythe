using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterViewer : MonoBehaviour {

    [SerializeField]
    private Image _image;

    private Sprite[] _sprites;

    private int i = 0;

    [SerializeField]
    private Sprite _spr1;
    [SerializeField]
    private Sprite _spr2;
    [SerializeField]
    private Sprite _spr3;

    [SerializeField]
    private GameObject _character;

    private Sprite _characterSprite;
    

    // Use this for initialization
    void Start () {
        _image.GetComponent<Image>();
        _character.GetComponent<SpriteRenderer>().sprite = _characterSprite;


        _sprites = new Sprite[3];

        _sprites[0] = _spr1;
        _sprites[1] = _spr2;
        _sprites[2] = _spr3;
	}
	
	// Update is called once per frame
	void Update () {
        _image.sprite = _sprites[i];
        _characterSprite = _sprites[i];
        _character.GetComponent<SpriteRenderer>().sprite = _characterSprite;
    }

    public void Next()
    {
        if(i < 2)
        {
            i += 1;
        }
        else
        {
            i = 0;
        }
    }

    public void Previous()
    {
        if(i > 0)
        {
            i -= 1;
        }
        else
        {
            i = 2;
        }
    }
}
