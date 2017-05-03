---
-api-id: T:Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TargetApplicationChosenEventArgs : Windows.ApplicationModel.DataTransfer.ITargetApplicationChosenEventArgs
-->

# Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs

## -description
Contains information about the target app the user chose to share content with. To get this object, you must handle the [TargetApplicationChosen](datatransfermanager_targetapplicationchosen.md) event.

## -remarks

## -examples


```javascript
var dataTransferManager = Windows.ApplicationModel.DataTransfer.getForCurrentView();
dataTransferManager.addEventListener("targetapplicationchosen", onTargetApplicationChosen);

function onTargetApplicationChosen(targetApplicationChosentEvent) {
    var appChosenDiv = document.createElement("div");
    appChosenDiv.innerText = targetApplicationChosenEvent.applicationName;
    document.body.appendChild("appChosenDiv");
}
```



## -see-also