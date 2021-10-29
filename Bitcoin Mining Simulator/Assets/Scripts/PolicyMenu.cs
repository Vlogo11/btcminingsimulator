using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicyMenu : MonoBehaviour
{

    private string policyKey = "policy";

    void Start()
    {
        var accepted = PlayerPrefs.GetInt(policyKey, 0) ==1;

        if(accepted)
            return;

        SimpleGDPR.ShowDialog( new TermsOfServiceDialog().
		    SetTermsOfServiceLink("https://policies.google.com/terms?hl=en-US").
		    SetPrivacyPolicyLink("https://policies.google.com/privacy?hl=en-US"),
            onMenuClosed);
    }

    private void onMenuClosed()
    {
        Debug.LogWarning("Policy accepted");
        PlayerPrefs.SetInt(policyKey, 1);
    }

}
