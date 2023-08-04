using UnityEngine;
using UnityEngine.Serialization;

namespace VLB.Samples
{
    public class Rotater : MonoBehaviour
    {
        [FormerlySerializedAs("m_EulerSpeed")]
        public Vector3 EulerSpeed = Vector3.zero;
        public float Speed = 1;
        void Update()
        {
            var euler = transform.rotation.eulerAngles;
            euler += EulerSpeed * Time.deltaTime* Speed;
            transform.rotation = Quaternion.Euler(euler);
        }
    }
}
