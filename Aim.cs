using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    //public float speed = 5f;
 
    private void Update()
    {
        Ray aimRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane basePlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;
        
        if (basePlane.Raycast(aimRay, out rayLength))
        {
            Vector3 pointToLook = aimRay.GetPoint(rayLength);
           

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
