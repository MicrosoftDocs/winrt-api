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
An instance of this object is returned by the [RevocationAndRenewalInformation.Items](revocationandrenewalinformation_items.md) property. This information can be passed to [ComponentRenewal.RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync.md) for system processing.

## -examples
This example shows a [ComponentLoadFailedEventHandler](componentloadfailedeventhandler.md). A loop iterates through the failed components. And [RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync.md) is invoked. Note that the [RevocationAndRenewalInformation](revocationandrenewalinformation.md) is passed in through the [ComponentLoadFailedEventArgs](componentloadfailedeventargs.md).

```javascript
function ComponentLoadFailed(e) {

    for (var i = 0; i < e.information.items.size; i++) {
        LogMessage('Component Name=' + 
                    e.information.items[i].name + 
                    '<BR/>');
        LogMessage('Failure Reason=' + 
                    e.information.items[i].reasons.toString(16) + 
                    '<BR/>');
        LogMessage('Renewal GUID=' + 
                    e.information.items[i].renewalId + 
                    '<BR/>');
    }

    //  Invoke the revocation               
    ComponentRenewal.renewSystemComponentsAsync(e.information).then(
        function (r) {
            LogMessage("RenewSystemComponentsAsync: " + 
                        r.toString() + 
                        '<BR/>');

            e.completion.complete(false);
        }
    );
};
```



## -see-also