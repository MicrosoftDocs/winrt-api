---
-api-id: T:Windows.Media.Protection.ServiceRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ServiceRequestedEventArgs : Windows.Media.Protection.IServiceRequestedEventArgs, Windows.Media.Protection.IServiceRequestedEventArgs2
-->

# Windows.Media.Protection.ServiceRequestedEventArgs

## -description
Contains event data for a [MediaProtectionManager](mediaprotectionmanager_mediaprotectionmanager_1221375020.md) object when a service is requested.

## -remarks
This object is not instantiated directly. It is created by the [MediaProtectionManager.ServiceRequested](mediaprotectionmanager_servicerequested.md) event and is returned as an argument to the [ServiceRequestedEventHandler](servicerequestedeventhandler.md) delegate.

## -examples
The following example shows how to create a [MediaProtectionManager](mediaprotectionmanager.md), set the [Properties](mediaprotectionmanager_properties.md) property, and add event listeners for [ComponentLoadFailed](mediaprotectionmanager_componentloadfailed.md) and [ServiceRequested](mediaprotectionmanager_servicerequested.md). See the [How to use pluggable DRM](/previous-versions/windows/apps/hh452779(v=win.10)) topic for the full example. ```javascript

mediaProtectionManager = 
    new Windows.Media.Protection.MediaProtectionManager();

function ServiceRequested(e) {
   logMsg("Got Enabler - system/type: {" + e.request.protectionSystem + "}/{" + e.request.type + "}");
   e.completion.complete(true);
}


function ComponentLoadFailed(e) {
   logMsg(e.information.items.size.toString() + " failed components");
   logMsg("<h2>Components:</h2>");

   //  List the failing components
   for (var i = 0; i < e.information.items.size; i++) {
      logMsg("<h3>" + e.information.items[i].name + "</h3>" +
             "<p>Reasons=0x" + e.information.items[i].reasons.toString(16) +
             "<p>Renewal Id=" + e.information.items[i].renewalId);
   }

   e.completion.complete(false);
}

function RebootNeeded(e) {
   logMsg("Reboot Required");
}

mediaProtectionManager.addEventListener("servicerequested", ServiceRequested, false);
mediaProtectionManager.addEventListener("componentloadfailed", ComponentLoadFailed, false);
mediaProtectionManager.addEventListener("rebootneeded", RebootNeeded, false);
 

```



## -see-also