using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    [SerializeField] GameObject objCursor;
    [SerializeField] Transform trsCannon;

    Camera camMain;
    void Start()
    {
        camMain = Camera.main;
    }

    
    void Update()
    {
        checkMouse();
    }

    private void checkMouse()
    {
        Ray ray = camMain.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit,100f, LayerMask.GetMask("Ground")) ) 
        {
            objCursor.SetActive(true);

            objCursor.transform.position = hit.point + Vector3.up * 0.0001f;
        }
        else
        {
            objCursor.SetActive(false);
        }
    }
}
