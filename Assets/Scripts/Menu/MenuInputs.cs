using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputs : MonoBehaviour {

    [SerializeField] KeyCode pauseButton;
    [SerializeField] KeyCode reloadButton;
    public Pause pause;

    void Start()
    {
        pause = GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update () {
        //pause

        //PC
        if (Input.GetKeyDown(KeyCode.Escape) && !pause.isPaused)
        {
            pause.OnPause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && pause.isPaused)
        {
            pause.Resume();
        }

        //Testing the gameover screen
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause.OnGameOver();
        }

        //Controller
        //put here ur controller shit :3
        if (Input.GetKeyDown(pauseButton) && !pause.isPaused)
        {
            pause.OnPause();
        }
        else if (Input.GetKeyDown(pauseButton) && pause.isPaused)
        {
            pause.Resume();
        }
        if (Input.GetKeyDown(reloadButton) && pause.isPaused)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            pause.Resume();
        }
    }
}
