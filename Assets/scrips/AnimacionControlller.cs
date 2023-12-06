using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionControlller : MonoBehaviour
{
    [Header("Component References")]
    public Animator playerAnimator;

    //Animation String IDs
    private int playerMovementAnimation;
    private int playerAttackAnimation;
    private int playerRunAnimation;
    private int playerRollAnimation;
    private int playerDa�o1Animation;
    private int playerDa�oAnimation;
    private int playerPatadaAnimation;
    private int playerPatadaSaltoAnimation;
    private int playerGolpeAnimation;

    public void SetupBehaviour()
    {
        //SetupAnimation();
    }

    void SetupAnimations()
    {
        playerMovementAnimation = Animator.StringToHash("Movement");
        playerAttackAnimation = Animator.StringToHash("Attack");
        playerRunAnimation = Animator.StringToHash("Run");
        playerRollAnimation = Animator.StringToHash("Rodar");
        playerDa�o1Animation = Animator.StringToHash("Da�o1"); // Nueva variable para la animaci�n de da�o1
        playerDa�oAnimation = Animator.StringToHash("Da�o"); // Nueva variable para la animaci�n de da�o
        playerPatadaAnimation = Animator.StringToHash("Patada"); // Nueva variable para la animaci�n de patada
        playerPatadaSaltoAnimation = Animator.StringToHash("Patada Salto"); // Nueva variable para la animaci�n de patada salto
        playerGolpeAnimation = Animator.StringToHash("Golpe"); // Nueva variable para la animaci�n de golpe
    }

    public void UpdateMovementAnimation(float movementBlendValue)
    {
        playerAnimator.SetFloat(playerMovementAnimation, movementBlendValue);
    }

    public void PlayAttackAnimation()
    {
        playerAnimator.SetTrigger(playerAttackAnimation);
    }
}
