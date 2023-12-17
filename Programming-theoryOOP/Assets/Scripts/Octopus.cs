using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Octopus : Movement
{
    // Start is called before the first frame update
    public string Name { get; private set; }

    void Start()
    {
        // ABSTRACTION AND POLYMORPHISM
        base.Start(); // used base to reduce code
        Name = "Octopus";
    }

    // Update is called once per fram   e
    void Update()
    {
        base.Update();
        SpecialAbility();
    }

    public override void SpecialAbility()
    {
        
        base.SpecialAbility();
        // POLYMORPHISM
        Debug.Log("Octopus special attack!");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetTrigger("Special");
        }

        // new branch functionality
    }
}
