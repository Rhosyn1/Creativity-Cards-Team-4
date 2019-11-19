using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JournalScript : MonoBehaviour
{
    //Crab
    public Image crabImage;
    //public Image fishImage;
    //public Image jellyfishImage;
    //public Image morayImage;
    //public Image seahorseImage;
    //public Image seaweedImage;
    //public Image sharkImage;
    //public Image squidImage;
    public void onTriggerEnter(Collider other)
    {
        //if crab is clicked on and successfully interrogated then crab page overlays blank page
        //Crab overlay covers half of BGV3
        if (other.CompareTag("Crab"))
        {
            //over the cover
            crabImage.enabled = true;
        }

    }
}
