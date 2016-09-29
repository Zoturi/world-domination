using UnityEngine;
using System.Collections;

public abstract class ManaPanel : MonoBehaviour {

    public void InitialisePanel()
    {
        Debug.Log("Panel initialised");
    }

    public void RefreshPanel()
    {
        Debug.Log("Panel refreshed");
    }
    
}
