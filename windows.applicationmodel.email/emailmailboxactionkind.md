---
-api-id: T:Windows.ApplicationModel.Email.EmailMailboxActionKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailMailboxActionKind : int
-->

# EmailMailboxActionKind

## -description
Defines the kind of action to be taken.

## -enum-fields
### -field MarkMessageAsSeen:0
Mark the email message as seen.

### -field MarkMessageRead:1
Mark the email message as having been read.

### -field ChangeMessageFlagState:2
Change the flag state on the email message.

### -field MoveMessage:3
Move the email message.

### -field SaveDraft:4
Save a draft of the email message.

### -field SendMessage:5
Send the email message.

### -field CreateResponseReplyMessage:6
Create a reply email message addressed to the sender in response to this email message.

### -field CreateResponseReplyAllMessage:7
Create a reply email message addressed to the sender and all recipients in response to this email message.

### -field CreateResponseForwardMessage:8
Create an email message to be forwarded containing the content of this email message.

### -field MoveFolder:9
Move this folder.

### -field MarkFolderForSyncEnabled:10
Enable sync for this folder.


## -remarks

## -examples

## -see-also