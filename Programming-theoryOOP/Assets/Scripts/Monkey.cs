using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Monkey : Movement
{
    // Encapsulation
    public string Name { get; private set; }

    // Start is called before the first frame update
    
    void StartMonkey()
    {
        // Abstraction
        base.Start();
    }

    private void Update()
    {
        base.Update();
        SpecialAbility();
    }



    public override void SpecialAbility()
    {
        //POLYMORPHISM
        base.SpecialAbility();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Monkey special ability");
            m_Animator.SetTrigger("Special");
        }

    }

    


}
