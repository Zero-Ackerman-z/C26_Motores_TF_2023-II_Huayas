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
    private int playerDaño1Animation;
    private int playerDañoAnimation;
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
        playerDaño1Animation = Animator.StringToHash("Daño1"); // Nueva variable para la animación de daño1
        playerDañoAnimation = Animator.StringToHash("Daño"); // Nueva variable para la animación de daño
        playerPatadaAnimation = Animator.StringToHash("Patada"); // Nueva variable para la animación de patada
        playerPatadaSaltoAnimation = Animator.StringToHash("Patada Salto"); // Nueva variable para la animación de patada salto
        playerGolpeAnimation = Animator.StringToHash("Golpe"); // Nueva variable para la animación de golpe
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
