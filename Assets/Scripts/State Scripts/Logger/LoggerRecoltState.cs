using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LoggerRecoltState : StateMachineBehaviour
{
    LoggerData loggerData;
    NavMeshAgent agent;

    float recolt_cooldown = 1.5f;
    private float timeSinceLastHit = 0.0f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isGoingToRecolt", false);

        agent = animator.GetComponent<NavMeshAgent>();
        loggerData = animator.GetComponent<LoggerData>();

        //Active & d�sactive bons objets
        loggerData.carriedLog.SetActive(false);
        loggerData.loggerAxe.SetActive(true);

        agent.SetDestination(animator.transform.position);
        animator.transform.LookAt(loggerData.targetTree);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timeSinceLastHit += Time.deltaTime;

        if (loggerData.targetTree != null) 
        {
            //Si cooldown atteint, on coupe
            if (timeSinceLastHit >= recolt_cooldown)
            {
                animator.SetTrigger("Cut");
                timeSinceLastHit = 0.0f;
                //Rq : La m�thode Recolt(loggerData) est appel� en Event de l'animation de coupe(fin)
            }
        }
        else 
        {
            //Si stock > 0 et n'a pas �t� renvoy� entre temps
            if (loggerData.stock >= 0 && !animator.GetBool("isFired")) 
            {
                animator.SetBool("isCarryingWood", true);
            }

            animator.SetBool("isRecolting", false);

        }

    }

}
