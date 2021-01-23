using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Octahedral {

  public class IKJoint : MonoBehaviour
  {
    // Draw gizmos in editor for range of motion

    // Range of motion
    [Header("Joint Limits")]

    [SerializeField] private float xOffset;
    [SerializeField] private float yOffset;
    [SerializeField] private float zOffset;

    [SerializeField] private float xAngleRange;
    [SerializeField] private float yAngleRange;
    [SerializeField] private float zAngleRange;

    public Vector3 StartOffset; 

    void Awake() {
      // set our offset from the parent
      StartOffset = transform.localPosition;
    }


    // void OnSceneGui() {
    //   // X
    //   Handles.color = new Color(0f, 1f, 0f);
    //   Handles.DrawSolidArc(transform.position,
    //                        transform.right,
    //                        transform.up,
    //                        xAngleRange,
    //                        1.0f);
    //   //HandleUtility.GetHandleSize(transform.position));
    // }



  }

}
