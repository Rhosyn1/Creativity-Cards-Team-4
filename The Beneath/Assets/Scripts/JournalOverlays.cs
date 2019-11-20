using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JournalOverlays: MonoBehaviour
{
    //creating images
    public Image crabImage;
    public Image fishImage;
    public Image jellyfishImage;
    public Image morayImage;
    public Image seahorseImage;
    public Image seaweedImage;
    public Image sharkImage;
    public Image squidImage;

    //checking for trigger
    public void onTriggerEnter(Collider other)
    {
        //checking tags
        if (other.CompareTag("Crab"))
        {
            //over the cover
            crabImage.enabled = true;
        }

        else if (other.CompareTag("Fish"))
        {
            fishImage.enabled = true;
        }

        else if (other.CompareTag("Jellyfish"))
        {
            jellyfishImage.enabled = true;
        }

        else if (other.CompareTag("Moray"))
        {
            morayImage.enabled = true;
        }

        else if (other.CompareTag("Seahorse"))
        {
            seahorseImage.enabled = true;
        }

        else if (other.CompareTag("Shark"))
        {
            sharkImage.enabled = true;
        }

        else if (other.CompareTag("Squid"))
        {
            fishImage.enabled = true;
        }

        else
        {
            Debug.Log("No Trigger");
        }

    }

}
