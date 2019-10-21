---
-api-id: T:Windows.Media.Protection.RevocationAndRenewalInformation
-api-type: winrt class
---

<!-- Class syntax.
public class RevocationAndRenewalInformation : Windows.Media.Protection.IRevocationAndRenewalInformation
-->

# Windows.Media.Protection.RevocationAndRenewalInformation

## -description
Contains information about components that need to be revoked and renewed.

## -remarks
An instance of this object is returned by the [ComponentLoadFailedEventArgs.Information](componentloadfailedeventargs_information.md) property.

## -examples
This example shows a [ComponentLoadFailedEventHandler](componentloadfailedeventhandler.md). A loop iterates through the failed components. And [RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync_1438723694.md) is invoked. Note that the RevocationAndRenewalInformation is passed in through the [ComponentLoadFailedEventArgs](componentloadfailedeventargs.md).

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
