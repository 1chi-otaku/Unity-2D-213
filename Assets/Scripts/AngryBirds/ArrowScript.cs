using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    // Arrow Rotation Script

    [SerializeField] private Transform rotAnchor;
    private float minRotAngle = -35.0f;
    private float maxRotAngle = 50.0f;

    void Update()
    {
        float dy = Input.GetAxis("Vertical");
        float curRotAngle = this.transform.eulerAngles.z;
        if (curRotAngle > 180) curRotAngle -= 360;
        if(curRotAngle + dy > minRotAngle && curRotAngle + dy < maxRotAngle)
        {
            this.transform.RotateAround(rotAnchor.position, Vector3.forward, dy);
        }
        //float rotAngle = Mathf.Clamp(curRotAngle + dy, minRotAngle, maxRotAngle);
        
    }
}
