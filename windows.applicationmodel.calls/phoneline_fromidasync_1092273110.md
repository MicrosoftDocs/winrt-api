---
-api-id: M:Windows.ApplicationModel.Calls.PhoneLine.FromIdAsync(System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Calls.PhoneLine> FromIdAsync(System.Guid lineId)
-->

# Windows.ApplicationModel.Calls.PhoneLine.FromIdAsync

## -description
This static method asynchronously retrieves a [PhoneLine](phoneline.md) object that represents a specific phone line on the device based on the line ID.

## -parameters
### -param lineId
The line ID of the phone line to retrieve.

## -returns
An asynchronous operation that returns a [PhoneLine](phoneline.md) object that represents a specific phone line on the device based on the line ID.
It will throw an exception on failure. 

## -remarks
The following example shows how to get the default [PhoneLine](phoneline.md).



[!code-csharp[GetDefaultLine](../windows.applicationmodel.calls/code/ApplicationModel.Calls/cs/Scenario1.cs#SnippetGetDefaultLine)]

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
