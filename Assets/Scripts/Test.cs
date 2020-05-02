using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Die m_dice = null;

    [SerializeField]
    private Camera m_camera = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            m_dice.transform.localPosition = new Vector3(0.0f, 30.0f, 0.0f);
            var rigi = m_dice.GetComponent<Rigidbody>();
            rigi.angularVelocity = new Vector3(Random.Range(0.01f, 1.0f), Random.Range(0.01f, 1.0f), Random.Range(0.01f, 1.0f)).normalized * (200.0f * Random.Range(0.0f, 1.0f) + 200.0f);
            rigi.velocity = new Vector3(Random.Range(0.0f, 1.0f) * 10.0f, Random.Range(0.0f, 1.0f) * 10.0f, Random.Range(0.0f, 1.0f) * 10.0f);
        }
        m_camera.transform.localPosition = m_dice.transform.localPosition + Vector3.up * 2.0f;
    }
}
