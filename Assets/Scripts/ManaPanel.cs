using UnityEngine;
using System.Collections;

public abstract class ManaPanel : MonoBehaviour {

    

    public void InitialisePanel()
    {
        Debug.Log("Panel initialised!");
        //  gameObject.SetActive(true);
        //  gameObject.SetActive(false);
        
    }

    public void RefreshPanel()
    {
        Debug.Log("refreshed panel");
        
        
    }


}
