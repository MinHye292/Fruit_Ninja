using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public GameObject bladeTrailPrefab;
    public bool isCutting = false;

    Rigidbody2D rb;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if(isCutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut ()
    {
        rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    
    void StartCutting()
    {
        isCutting = true;
        Instantiate(bladeTrailPrefab, transform);
    }
    void StopCutting()
    {
        isCutting = false;
    }
}
