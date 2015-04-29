using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    private Animator anim;
    private CanvasGroup canGroup;

    public bool IsOpen
    {
        get { return anim.GetBool("IsOpen"); }
        set { anim.SetBool("IsOpen", value); }
    }

    public void Awake()
    {
        anim = GetComponent<Animator>();
        canGroup = GetComponent<CanvasGroup>();

        var rect = GetComponent<RectTransform>();
        rect.offsetMax = rect.offsetMin = new Vector2(0, 0);
    }

    public void Update()
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            canGroup.blocksRaycasts = canGroup.interactable = false;
        }
        else
        {
            canGroup.blocksRaycasts = canGroup.interactable = true;
        }
    }
}
