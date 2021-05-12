using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mug : MonoBehaviour
{
    public GameObject mLiquid;
    public GameObject mLiquidMesh;

    private int mSloshSpeed = 60;
    private int mRotationSpeed = 0;
    private int difference = 0;

    void Update()
    {
        Slosh();

        mLiquidMesh.transform.Rotate(Vector3.up * mRotationSpeed * Time.deltaTime, Space.Self);
    }

    private void Slosh()
    {
        Quaternion inverseRotation = Quaternion.Inverse(transform.localRotation);

        Vector3 finalRotation = Quaternion.RotateTowards(mLiquid.transform.localRotation, inverseRotation, mSloshSpeed * Time.deltaTime).eulerAngles;

        finalRotation.x = ClampRotationValue(finalRotation.x, difference);
        finalRotation.z = ClampRotationValue(finalRotation.z, difference);

        mLiquid.transform.localEulerAngles = finalRotation;
    }

 
    private float ClampRotationValue(float value, float difference)
    {
            float returnValue = 0.0f;

            if (value > 180)
                {

            returnValue = Mathf.Clamp(value, 360 - difference, 360);
                }
             else
               {
            returnValue = Mathf.Clamp(value, 0, difference);
        }

        return returnValue;

    }
}
