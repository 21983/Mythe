using UnityEngine;
using UnityEngine.SceneManagement;

public class StartRealGame : MonoBehaviour
{

    [SerializeField] KeyCode startSelect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(startSelect))
        {
            SceneManager.LoadScene("Joppe");
        }
    }
}
