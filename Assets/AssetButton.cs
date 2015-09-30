using UnityEngine;
using System.Collections;

public class AssetButton : MonoBehaviour
{
    public GameObject assetbackground;
    private bool toggle = false;
        public void AssetMenuToggleClicked()
        {
        if (toggle == false)
        {
            CancelInvoke("SlideDown");
            InvokeRepeating("SlideUp", 0.0f, .0001f);
            toggle = true;
        }
        else
        {
            CancelInvoke("SlideUp");
            InvokeRepeating("SlideDown", 0.0f, .0001f);
            toggle = false;
        }
    }
        void Update()
        {
            if ((assetbackground.transform.position.y > -.88) && (toggle == true))
            {
                CancelInvoke("SlideUp");
            assetbackground.transform.position = new Vector3(0.00f,-.68f,-2.00f);
            }
            if ((assetbackground.transform.position.y < -8.05) && (toggle == false))
                {
                CancelInvoke("SlideDown");
                assetbackground.transform.position = new Vector3(0.00f, -8.07f, -2.00f);
            }
    }
        void SlideUp()
        { 
            assetbackground.transform.Translate(Vector3.up * 6 * Time.deltaTime);
        }
        void SlideDown()
        {
            assetbackground.transform.Translate(Vector3.up * -5 * Time.deltaTime);
        }
}
