using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//EP03 minute 1:15
public class SpriteSwitcher : MonoBehaviour
{
    public bool isSwitched = false;
    public Image image1;
    public Image image2;
    
    public Animator animator;

    public void SwitchImage(Sprite sprite)
    {
        if(!isSwitched)
        {
            image2.sprite = sprite; 
            animator.SetTrigger("SwitchFirst");
        }
        else
        {
            image1.sprite = sprite; 
            animator.SetTrigger("SwitchSecond");
        }
        isSwitched = !isSwitched;
    }

    public void SetImage(Sprite sprite)
    {
        if(!isSwitched)
        {
            image2.sprite = sprite; 
            //animator.SetTrigger("SwitchFirst");
        }
        else
        {
            image1.sprite = sprite; 
            //animator.SetTrigger("SwitchSecond");
        }
    }

    public Sprite GetImage()
    {
        if(!isSwitched)
        {
            return image1.sprite; 
            
        }
        else
        {
            return image2.sprite; 
            
        }
    }
}
