using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guncontroller : MonoBehaviour
{
    [SerializeField] GameObject bulletObj = null;

    [SerializeField] int magazine;

    [SerializeField] float shotSpeed;

    [SerializeField] float shotInterval;

    AudioSource audioSource;

    Animator m_anim;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        m_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("照準");

            if (m_anim)
            {
                m_anim.SetBool("Lock",true);
            }
        }
        else if (Input.GetMouseButtonUp(1))
        {
            if (m_anim)
            {
                m_anim.SetBool("Lock",false);
            }
        }

    }

    
}
