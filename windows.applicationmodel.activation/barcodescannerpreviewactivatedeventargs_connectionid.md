---
-api-id: P:Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.ConnectionId
-api-type: winrt property
---

<!-- Property syntax.
public string ConnectionId { get; }
-->

# Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.ConnectionId

## -description
Gets a connection ID used to match the service connection.

## -property-value
A connection ID.

## -remarks

## -see-also

## -examples
This example gets a connction ID from an activated argument, and then uses it to start the video preview page.

```csharp
protected override async void OnActivated(IActivatedEventArgs args)
{
    base.OnActivated(args);

    if (args.Kind == ActivationKind.BarcodeScannerProvider)
    {
        ... // Create and activate root frame. 

        var eventArgs = args as BarcodeScannerPreviewActivatedEventArgs;
        string connectionId = eventArgs.ConnectionId;

        BarcodeScannerProviderConnection connection = _taskList.GetConnection(connectionId);
        if (connection != null)
        {
            var page = rootFrame.Content as MainPage;
            if (page != null)
            {
                await page.StartVideoPreview(connection);
            }
        }
    }
}



```
