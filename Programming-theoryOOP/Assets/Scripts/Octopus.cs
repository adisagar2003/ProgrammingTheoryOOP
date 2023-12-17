using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : Movement
{
    // Start is called before the first frame update
    public string Name { get; private set; }

    void Start()
    {
        base.Start();
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
        Debug.Log("Octopus special attack!");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetTrigger("Special");
        }
    }
}
