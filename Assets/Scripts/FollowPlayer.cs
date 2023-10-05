using System;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
        private void LateUpdate()
        {
                GameObject player = GameObject.Find("Player");
                Vector3 target = player.transform.position + new Vector3(1.5f, 1, -4);
                transform.position = target;
        }

}