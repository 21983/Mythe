using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MultipleTargetCam : MonoBehaviour {

	public List<Transform> targets;

    public Vector3 offset;
    public float smoothTime = 0.5f;

    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 50f;

    private Vector3 _velocity;

    [SerializeField]
    private Camera cam;

    void Start()
    {
        //cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if(targets.Count == 0)
        {
            return;
        }

        Movement();
        Zoom();
      
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(minZoom, maxZoom, GetGreatestDisctance() / zoomLimiter);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
        Debug.Log(cam.fieldOfView);
    }

    void Movement()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref _velocity, smoothTime);
    }

    float GetGreatestDisctance()
    {
        var bounds = new Bounds(targets[0].position, Vector2.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x;
    }

    Vector2 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector2.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }

}
