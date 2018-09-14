using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStateBehavior : StateMachineBehaviour {

    [SerializeField] FighterStates behaviourStates;
    [SerializeField] AudioClip soundsEffect;
    [SerializeField] float horizontalForce;
    [SerializeField] float verticalForce;
    protected FIGHTER fighter;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (fighter == null)
        {
            fighter = animator.gameObject.GetComponent<FIGHTER>();


        }
        fighter.currentStates = behaviourStates;
        if (soundsEffect!=null)
        {
            //fighter.PlaySound(soundsEffect);
        }
        fighter.body.AddRelativeForce(new Vector3(0, verticalForce, 0));
    }
    override public void OnStateUpdate(Animator animator,
                                       AnimatorStateInfo stateInfo, int layerIndex)
    {
        fighter.body.AddRelativeForce(new Vector3(0, 0, horizontalForce));
    }



}
