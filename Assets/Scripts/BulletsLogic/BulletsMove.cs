using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class BulletsMove : MonoBehaviour
    {
        [SerializeField] float speed = 40.0f;

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}