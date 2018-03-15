using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour {

    [SerializeField]
    private GameObject cam;

	void Start () {
        cam = GameObject.Find("Main Camera");
	}

	void Update () {
		if(cam.transform.position.y >= gameObject.transform.position.y + 20)
        {
            Destroy(gameObject);
        }
	}
}
