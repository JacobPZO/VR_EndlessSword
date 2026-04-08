using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerSword : MonoBehaviour
    {
        [SerializeField]
        //The object that PhysicsTracer will get physics data from
        public Transform m_ToTrack;

        PhysicsTracker m_MotionData = new PhysicsTracker();

        // Start is called before the first frame update
        void Start()
        {
            var position = m_ToTrack.position;
            m_MotionData.Reset(position, m_ToTrack.rotation, Vector3.zero, Vector3.zero);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            var position = m_ToTrack.position;
            m_MotionData.Update(position, m_ToTrack.rotation, Time.smoothDeltaTime);
            UnityEngine.Debug.Log(m_MotionData.Velocity.ToString());
        }
    }