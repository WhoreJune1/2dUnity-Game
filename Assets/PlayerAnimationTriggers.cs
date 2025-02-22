using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Player player => GetComponentInParent<Player>();

    private void AnimationTrigger() 
    {
        player.AnimationTrigger();
    }

}
