---
-api-id: T:Windows.Media.Protection.ComponentRenewal
-api-type: winrt class
---

<!-- Class syntax.
public class ComponentRenewal 
-->

# Windows.Media.Protection.ComponentRenewal

## -description
Enables applications to initiate renewal of components which need updating in order to play protected media content.

## -remarks


## -examples
This example shows a [ComponentLoadFailedEventHandler](componentloadfailedeventhandler.md). A loop iterates through the failed components. And [RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync_1438723694.md) is invoked. Note that the [RevocationAndRenewalInformation](revocationandrenewalinformation.md) is passed in through the [ComponentLoadFailedEventArgs](componentloadfailedeventargs.md).

```csharp
private async void Manager_ComponentLoadFailed(MediaProtectionManager sender, ComponentLoadFailedEventArgs e)
{
    for (var i = 0; i < e.Information.Items.Count; i++)
    {
        Debug.WriteLine('Component Name=' +
                    e.Information.Items[i].Name +
                    "<BR/>");
        Debug.WriteLine('Failure Reason=' +
                    e.Information.Items[i].Reasons.ToString(16) +
                    "<BR/>");
        Debug.WriteLine('Renewal GUID=' +
                    e.Information.Items[i].RenewalId +
                    "<BR/>");
    }



    //  Invoke the revocation               
    var renewalStatus = await ComponentRenewal.RenewSystemComponentsAsync(e.Information);
    Debug.WriteLine("RenewSystemComponentsAsync: " +
                    renewalStatus.ToString() +
                    "<BR/>");

    e.Completion.Complete(false);
}
```



## -see-also
