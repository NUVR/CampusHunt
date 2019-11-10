using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Camera))]

public class la : MonoBehaviour
{
    [SerializeField]
    string NextScene;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                var cam = GetComponent<Camera>();
                bool hit3D = Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hitInfo, 20.0f, Physics.DefaultRaycastLayers);
                if (hit3D && hitInfo.transform.gameObject.tag == "QR")
                {
                    SceneManager.LoadScene(NextScene);
                }
            }
        }
        
    }
}
