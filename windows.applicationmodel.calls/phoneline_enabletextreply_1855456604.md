---
-api-id: M:Windows.ApplicationModel.Calls.PhoneLine.EnableTextReply(System.Boolean)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public HResult PhoneLine.EnableTextReply(Boolean value)
-->

# Windows.ApplicationModel.Calls.PhoneLine.EnableTextReply

## -description
Informs the platform that text reply functionality is supported for this line.

> [!NOTE]
> This method is deprecated.

## -parameters
### -param value
True to enable text reply functionality, and false otherwise.

## -remarks
By default, the platform assumes text reply functionality is not supported. It is recommended the app set this capability (if available) as soon as being notified of a LineChanged event indicating a new PhoneLine has been added.

## -see-also

## -examples

