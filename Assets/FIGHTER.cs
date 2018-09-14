using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIGHTER : MonoBehaviour {
   public enum PlayerType
    {
        HUMAN,AI
            
    };
    [SerializeField] PlayerType Player;
    public static float MAX_HEALTH = 100f;
    public float health = MAX_HEALTH;
    [SerializeField] string FighterName;
    protected Animator animator;
    private Rigidbody MyBody;
    public FighterStates currentStates = FighterStates.IDLE;

	// Use this for initialization
	void Start ()
    {
        MyBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Horizontal") >0.1)
        {
            animator.SetBool("WALK", true);
                
        }
        else
        {
            animator.SetBool("WALK", false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("PUNCH_L");
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("WALK_BACK", true);

        }
        else
        {
            animator.SetBool("WALK_BACK", false);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("KICK_R");
        }
        if (Input.GetAxis("Vertical") > 0.1)
        {
            animator.SetBool("JUMP", true);

        }
        else
        {
            animator.SetBool("JUMP", false);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("DEFEND",true);
        }
        else
        {
            animator.SetBool("DEFEND", false);
        }

    }
    public Rigidbody body
    {
        get
        {
            return this.MyBody;
        }
    }
}
