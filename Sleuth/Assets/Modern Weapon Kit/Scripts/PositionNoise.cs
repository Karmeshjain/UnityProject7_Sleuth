using UnityEngine;
using System.Collections;

namespace Fundamentals
{
    public class PositionNoise : MonoBehaviour
    {
        public bool local;

        public Vector3 power;
        public float speed;
        public int seed;

        [SerializeField]
        float m_master = 1f;
        public float master
        {
            get
            {
                return m_master;
            }
            set
            {
                if (m_master != value)
                    m_master = value;
            }
        }

        Vector3 m_initPosition;

        void Awake()
        {
            if (seed == 0)
                seed = Random.Range(0, 99999);
        }

        protected void OnEnable()
        {
            m_initPosition = local ? transform.localPosition : transform.position;
        }

        Vector3 m_positionResult;
        protected void Update()
        {
            if (m_master != 0f)
            {
                m_positionResult.x = power.x * (Mathf.PerlinNoise(Time.time * speed + seed, 0f) - 0.5f);
                m_positionResult.y = power.y * (Mathf.PerlinNoise(Time.time * speed + 50f + seed, 0f) - 0.5f);
                m_positionResult.z = power.z * (Mathf.PerlinNoise(Time.time * speed + 100f + seed, 0f) - 0.5f);
                m_positionResult *= master;

                if (local)
                    transform.localPosition = m_initPosition + m_positionResult;
                else
                    transform.position = m_initPosition + m_positionResult;
            }
        }
    }
}