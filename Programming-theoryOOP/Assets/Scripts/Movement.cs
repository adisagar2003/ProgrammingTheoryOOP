using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    // Start is called before the first frame update
    protected Animator m_Animator;
   
    protected void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        Debug.Log("Animator enabled from start");
    }

    // Update is called once per frame
    protected void Update()
    {
     

    }

    void HandleMovement()
    {
       

    }

    public virtual void SpecialAbility()
    {
        
    }
 
}
