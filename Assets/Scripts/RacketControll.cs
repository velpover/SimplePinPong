using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControll : MonoBehaviour
{
    [SerializeField] InputMouse _input;

    Transform racketPosition;

    Vector2 rangeX = new Vector2(-5, 5);
    Vector2 rangeY = new Vector2(0, 2.5f);

    Vector3 point = Vector3.zero;
    Vector3 rotate = Vector3.zero;

    Quaternion rotation = Quaternion.identity; 
    
    float rotateAngle = 30f;

    private void OnEnable()
    {
        racketPosition = transform;
    }

    private void OnDisable()
    {
        racketPosition = null;
    }

    private void LateUpdate()
    {   
       MoveRacket(_input.MousePosition);

    }

    private void MoveRacket(Vector3 mouseInput)
    {

        point = racketPosition.localPosition+mouseInput;

        point.x = Mathf.Clamp(point.x, rangeX.x, rangeX.y);
        point.y = Mathf.Clamp(point.y, rangeY.x, rangeY.y);

        rotate.x = (rotateAngle * point.y) * 0.4f;
        rotate.y = (rotateAngle * point.x) * -0.2f;

        rotation = Quaternion.Euler(rotate);

        racketPosition.localPosition = Vector3.Lerp(racketPosition.localPosition,point,0.1f);
        racketPosition.localRotation = Quaternion.Lerp(racketPosition.localRotation, rotation, 0.1f);
    }
}
