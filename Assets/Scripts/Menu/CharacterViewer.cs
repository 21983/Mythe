using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterViewer : MonoBehaviour {

    [SerializeField]
    private Image _image;

    private Sprite[] _sprites;
    private Sprite[] _clothes;

    //used for character select
    private int i = 0;

    [SerializeField]
    private Sprite _spr1, _spr2, _spr3, _spr4;

    [SerializeField]
    private Sprite _clo1, _clo2, _clo3, _clo4;

    [SerializeField]
    private GameObject _character;

    private SpriteRenderer _characterRenderer;

    private Sprite _characterSprite;

    private bool ChangedClothes = false;

    // Use this for initialization
    void Start () {
        //_character.GetComponent<SpriteRenderer>().sprite = _characterSprite;
        _characterRenderer = _character.GetComponent<SpriteRenderer>();
        _characterRenderer.sprite = _characterSprite;


        _sprites = new Sprite[8];

        //characters
        _sprites[0] = _spr1;
        _sprites[1] = _spr2;
        _sprites[2] = _spr3;
        _sprites[3] = _spr4;

        //clothes
        _sprites[4] = _clo1;
        _sprites[5] = _clo2;
        _sprites[6] = _clo3;
        _sprites[7] = _clo4;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(i);

        _image.sprite = _sprites[i];
        _characterSprite = _sprites[i];
        _characterRenderer.sprite = _characterSprite;
    }

    public void Next()
    {
        if (i < 3 && !ChangedClothes)
        {
            i += 1;
        }
        else if (!ChangedClothes)
        {
            i = 0;
        }
        else if (ChangedClothes)
        {
            i -= 4;
            ChangedClothes = false;
        }
    }

    public void Previous()
    {
        if(i > 0 && !ChangedClothes)
        {
            i -= 1;
        }
        else if(!ChangedClothes)
        {
            i = 3;
        }
        else if(ChangedClothes)
        {
            i -= 4;
            ChangedClothes = false;
        }
    }

    public void ChangeClothes()
    {
        if(ChangedClothes)
        {
            ChangedClothes = false;
            i -= 4;
        }
        else if(!ChangedClothes)
        {
            ChangedClothes = true;
            i += 4;
        }
    }
}
