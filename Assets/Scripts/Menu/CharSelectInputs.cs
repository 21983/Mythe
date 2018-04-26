using UnityEngine;

public class CharSelectInputs : MonoBehaviour {

    public JoinGame joinGame;
    public CharacterViewer characterViewer;

    private GameObject _canvas;

    private bool _joined = false;

    [SerializeField] KeyCode LeftArrow;
    [SerializeField] KeyCode RightArrow;
    [SerializeField] KeyCode UpArrow;
    [SerializeField] KeyCode DownArrow;

    [SerializeField] KeyCode Join;
    [SerializeField] KeyCode Leave;

	// Use this for initialization
	void Start () {
        _canvas = GameObject.Find("Canvas");
        joinGame = _canvas.GetComponent<JoinGame>();
        characterViewer = GetComponent<CharacterViewer>();
	}
	
	// Update is called once per frame
	void Update () {

        // IFS
        if (Input.GetKeyDown(Join) && !_joined)
        {
            _joined = true;
            joinGame.OnJoin();
        }

        if (Input.GetKeyDown(Leave) && _joined)
        {
            _joined = false;
            joinGame.OnLeave();
        }

        if (Input.GetKeyDown(UpArrow))
        {
            characterViewer.ChangeClothes();
        }

        if (Input.GetKeyDown(DownArrow))
        {
            characterViewer.ChangeClothes();
        }

        if (Input.GetKeyDown(LeftArrow))
        {
            characterViewer.Previous();
        }

        if (Input.GetKeyDown(RightArrow))
        {
            characterViewer.Next();
        }
    }
}
