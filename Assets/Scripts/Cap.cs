using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Cap : MonoBehaviour
{ 
    private Animator _animator;
    private string _openCapAnimationName = "Cap";
    private string _closeCapAnimationName = "CloseCap";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayOpenAnimation()
    {
        _animator.Play(_openCapAnimationName);
    }

    public void PlayCloseAnimation()
    {
        _animator.Play(_closeCapAnimationName);
    }
}
