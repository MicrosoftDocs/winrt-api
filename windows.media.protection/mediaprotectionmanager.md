---
-api-id: T:Windows.Media.Protection.MediaProtectionManager
-api-type: winrt class
---

<!-- Class syntax.
public class MediaProtectionManager : Windows.Media.Protection.IMediaProtectionManager
-->

# Windows.Media.Protection.MediaProtectionManager

## -description
Contains a content protection manager object for an application that handles protected media content.

## -remarks
The MediaProtectionManager can be passed to the media playback infrastructure in either of two ways: 
+ As an attribute for a `<video>` or `<audio>` tag using the [msSetMediaProtectionManager](/previous-versions/hh772532(v=vs.85)) method.
+ Directly to a media playback API. The MediaProtectionManager object is notified of content enabler objects. These objects must be processed by the application, to establish access to protected content. Each MediaProtectionManager object is associated with a single instance of playback.

## -examples
The following example shows how to create a MediaProtectionManager, set the [Properties](mediaprotectionmanager_properties.md) property, and add event listeners for [ComponentLoadFailed](mediaprotectionmanager_componentloadfailed.md) and [ServiceRequested](mediaprotectionmanager_servicerequested.md). See the [How to use pluggable DRM](/previous-versions/windows/apps/hh452779(v=win.10)) topic for the full example. 

```javascript

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

```csharp
private void InitMediaProtectionManager()
{
   mediaProtectionManager = new Windows.Media.Protection.MediaProtectionManager();
   mediaProtectionManager.ServiceRequested += MediaProtectionManager_ServiceRequested;
   mediaProtectionManager.ComponentLoadFailed += MediaProtectionManager_ComponentLoadFailed;
   mediaProtectionManager.RebootNeeded += MediaProtectionManager_RebootNeeded;
}



private void MediaProtectionManager_RebootNeeded(MediaProtectionManager sender)
{
   LogMessage("Reboot Required");
}

private void MediaProtectionManager_ComponentLoadFailed(MediaProtectionManager sender, ComponentLoadFailedEventArgs e)
{
   LogMessage(e.Information.Items.Count.ToString() + " failed components");
   LogMessage("<h2>Components:</h2>");

   //  List the failing components
   for (var i = 0; i < e.Information.Items.Count; i++)
   {
         LogMessage("<h3>" + e.Information.Items[i].Name + "</h3>" +
               "<p>Reasons=0x" + e.Information.Items[i].Reasons.ToString() +
               "<p>Renewal Id=" + e.Information.Items[i].RenewalId);
   }

   e.Completion.Complete(true);
}

private void MediaProtectionManager_ServiceRequested(MediaProtectionManager sender, ServiceRequestedEventArgs e)
{
   LogMessage("Got Enabler - system/type: {" + e.Request.ProtectionSystem + "}/{" + e.Request.Type + "}");
   e.Completion.Complete(true);
}

```

## -see-also
