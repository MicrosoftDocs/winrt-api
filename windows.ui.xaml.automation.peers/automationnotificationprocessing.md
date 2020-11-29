---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AutomationNotificationProcessing
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AutomationNotificationProcessing : int 
-->

# Windows.UI.Xaml.Automation.Peers.AutomationNotificationProcessing

## -description
Specifies the order in which to process a notification.

Equivalent WinUI enum: [Microsoft.UI.Xaml.Automation.Peers.AutomationNotificationProcessing](/windows/winui/api/microsoft.ui.xaml.automation.peers.automationnotificationprocessing).

## -enum-fields
### -field ImportantAll:0
These notifications should be presented to the user as soon as possible. All of the notifications from this source should be delivered to the user.  
  
> [!WARNING]
> Use this in a limited capacity as this style of message could cause a flooding for information to the end user due to the nature of the request to deliver all of the notifications.

### -field ImportantMostRecent:1
These notifications should be presented to the user as soon as possible. The most recent notifications from this source should be delivered to the user because the most recent notification supersedes all of the other notifications. 

### -field All:2
These notifications should be presented to the user when possible. All of the notifications from this source should be delivered to the user.  

### -field MostRecent:3
These notifications should be presented to the user when possible. Interrupt the current notification for this one.

### -field CurrentThenMostRecent:4
These notifications should be presented to the user when possible. Don’t interrupt the current notification for this one. If new notifications come in from the same source while the current notification is being presented, then keep the most recent and ignore the rest until the current processing is completed. Then use the most recent message as the current message. 

## -remarks

## -see-also

## -examples

