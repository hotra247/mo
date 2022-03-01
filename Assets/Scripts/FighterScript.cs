using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterScript : MonoBehaviour
{

    public bool BlockCheck = false

    public int Chooser;

    public float Cooldown = 0.25f

    private float CooldownTimer:
    
    private bool Attacking 0 false;

    private bool Hit = false

    public Transform PunchCheck;
    public Transform KickCheck;

    public float Range = 1.75

    public LayerMask EnemyLayer;
    public float PunchDamage = 2f;
    public float KickDamage = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
