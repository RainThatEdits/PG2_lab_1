using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //[Header("Player Stats")]
    [SerializeField] private float jump = 5f;
    [SerializeField] private float walkingSpeed = 5f;


    void Start()
    {
        
    }

    private void Awake()
    {
        Inputs.Init(this);


    }

    public void setLook(Vector2 w) { 
    
     }
    public void MoveTo (vetor2 s) {
        move = s;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *(MoveTo().y* Time.deltaTime)* walkingSpeed,Space.Self);
        transform.Translate(vector3.right *(MoveTo().x* Time.deltaTime)* walkingSpeed, Space.Self);   
    }

}
