using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Movement
{
    public string Name { get; private set; }

    // Start is called before the first frame update
    
    void StartMonkey()
    {
        base.Start();
    }

    private void Update()
    {
        base.Update();
        SpecialAbility();
    }



    public override void SpecialAbility()
    {
        base.SpecialAbility();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Monkey special ability");
            m_Animator.SetTrigger("Special");
        }

    }

    


}
