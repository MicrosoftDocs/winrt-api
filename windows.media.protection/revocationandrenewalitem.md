---
-api-id: T:Windows.Media.Protection.RevocationAndRenewalItem
-api-type: winrt class
---

<!-- Class syntax.
public class RevocationAndRenewalItem : Windows.Media.Protection.IRevocationAndRenewalItem
-->

# Windows.Media.Protection.RevocationAndRenewalItem

## -description
Represents a component that is being revoked and renewed with a trusted component.

## -remarks
An instance of this object is returned by the [RevocationAndRenewalInformation.Items](revocationandrenewalinformation_items.md) property. This information can be passed to [ComponentRenewal.RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync_1438723694.md) for system processing.

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