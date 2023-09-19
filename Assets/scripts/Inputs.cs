using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs
{
    // Start is called before the first frame update
    private static PlayerAction _actions;
    private static PlayerController _owner;

    public static  BindPlayer(PlayerController player)
    {
        _owner = player;


    }
public static void Init(PlayerController player){
        _actions = new PlayerAction();
        _actions.Player.Look.performed += ctx => _owner.SetLook1(ctx.ReadValue < Vector2>()); 
        _actions.Player.Move.Performed += ctx => _owner.MoveTo(ctx.readValue < Vector2.());

        }

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
