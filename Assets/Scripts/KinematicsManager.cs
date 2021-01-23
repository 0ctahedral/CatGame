using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Octahedral {
  
  /// Manages a set of joints
  public class KinematicsManager : MonoBehaviour
  {

    public List<IKJoint> joints;

    // TODO: automatically add joints in order
    public Transform target;


    void Update() {
      target.position = ForwardKinematics();
    }

    public Vector3 ForwardKinematics() {
      Vector3 prevPoint = joints[0].transform.position;
      Quaternion rotation = Quaternion.identity;
      for (int i = 1; i < joints.Count; i++)
      {
        // Rotates around a new axis
        rotation *= joints[i - 1].transform.localRotation;
        Vector3 nextPoint = prevPoint + rotation * joints[i].StartOffset;
    
        prevPoint = nextPoint;
      }
      return prevPoint;
    }
  }

}
