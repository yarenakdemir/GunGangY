using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public FollowPlayer followPlayer;

    public void SetTarget(GameObject followTarget)
    {
        followPlayer.player = followTarget;
        transform.LookAt(followTarget.transform);
    }
  
}
