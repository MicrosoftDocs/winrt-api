---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher

<!--
public sealed class TransferTargetWatcher
-->


## -description

The `TransferTargetWatcher` class enables applications to discover and monitor available transfer targets, such as apps or devices, in real time. It provides events and methods to manage the discovery process and interact with transfer targets dynamically.

## -remarks

The `TransferTargetWatcher` is a key component of the Transfer Target Platform API. It supports asynchronous discovery of transfer targets and notifies applications about changes in the available targets through events.

#### Key Features:

- **Real-Time Discovery**: Dynamically discovers transfer targets at runtime.
- **Event Notifications**: Provides events such as `Added`, `Removed`, `Updated`, `Stopped`, and `EnumerationCompleted` to keep applications informed about changes.
- **Seamless Integration**: Simplifies the process of integrating sharing functionalities into applications.

#### Events:

- `Added`: Triggered when a new transfer target is discovered.
- `Removed`: Triggered when a transfer target is no longer available.
- `Updated`: Triggered when a transfer target's properties are updated.
- `Stopped`: Triggered when the watcher stops monitoring.
- `EnumerationCompleted`: Triggered when the initial enumeration of transfer targets is complete.

## -see-also

[TransferTarget](transfertarget.md), [TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md), [TransferTargetInvokeResult](transfertargetinvokeresult.md)

## -examples

#### Initializing and Configuring a TransferTargetWatcher

This code sample shows how to initialize and configure a `TransferTargetWatcher` to discover five app targets and manage them based on a provided data package. It also sets up event handlers to track the addition, removal, and updating of transfer targets, and to handle the completion of the enumeration process.

```csharp
public class TransferTargetWatcherInitializer
{
    private List<TransferTarget> m_transferTargets;

    public void InitializeTransferTargetWatcher(DataPackage dataPackage)
    {
        // Check if the application supports TransferTargetWatcher
        if (!TransferTargetWatcher.IsSupported(dataPackage.GetView()))
        {
            return;
        }

        // Initialize a global list to store the discovered transfer targets
        m_transferTargets = new List<TransferTarget>();

        // Create a filter to customize the transfer targets discovery
        var transferTargetDiscoveryOptions = new TransferTargetDiscoveryOptions
        {
            DataPackage = dataPackage.GetView(),
            MaxAppTargets = 5
        };

        // Initialize TransferTargetWatcher using the configured filter
        var transferTargetWatcher = TransferTarget.CreateWatcher(transferTargetDiscoveryOptions);

        // Add a callback for the Added event to handle newly discovered transfer targets
        transferTargetWatcher.Added += (sender, args) =>
        {
            m_transferTargets.Add(args.Target);
        };

        // Add a callback for the Removed event to handle removed transfer targets
        transferTargetWatcher.Removed += (sender, args) =>
        {
            m_transferTargets.Remove(args.Target);
        };

        // Add a callback for the Updated event to handle updated transfer targets
        transferTargetWatcher.Updated += (sender, args) =>
        {
            // Handle the update of targets to allow targets to change their display over time
        };

        // Add a callback for the EnumerationCompleted event to handle the completion of the enumeration process
        transferTargetWatcher.EnumerationCompleted += (sender, args) =>
        {
            // The enumeration process has completed, and the application can now display the discovered transfer targets in the UI.
        };

        // Start the TransferTargetWatcher to begin discovering transfer targets
        transferTargetWatcher.Start();
    }
}
```

#### Invoking a Transfer Target

This code sample demonstrates how to use properties of `TransferTarget` and invoke a transfer target by using the `InvokeAsync` method on a `TransferTargetWatcher`. The `OnTargetButtonClick` method takes a `TransferTarget` and a `DataPackage` as parameters. It ensures that the `TransferTargetWatcher` is initialized before proceeding. The method handles the progress and completion of the invoke operation, providing feedback on the progress percentage and the final status of the invocation. If the invocation completes successfully, it prints the invoke status; otherwise, it indicates that the operation didn't complete successfully.

```xaml
<Button
    x:Name="TargetButton"
    Click="OnTargetButtonClick">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>

        <Grid>
            <ImageIcon
                x:Name="TargetPicture"
                Grid.Row="0"
                Width="32"
                Height="32"
                HorizontalAlignment="Center"
                Source="{x:Bind Target.DisplayIcon}" />

            <FontIcon
                x:Name="TargetPicturePlaceholder"
                Grid.Row="0"
                FontSize="32"
                VerticalAlignment="Center"
                HorizontalAlignment="Center"
                Glyph="&#xECAA;" />
        </Grid>

        <TextBlock
            x:Name="TargetTitleText"
            Grid.Row="1"
            Text="{x:Bind Target.Label, Mode=OneWay}" />
    </Grid>
</Button>
```

```csharp
// Invoking a transfer target
public async Task OnTargetButtonClick(TransferTarget target)
{
    if (m_transferTargetWatcher == null)
    {
        throw new InvalidOperationException("TransferTargetWatcher is not initialized.");
    }

    IntPtr handle = GetForegroundWindow();
    WindowId windowId = WindowId.FromWindowHandle(handle);

    var invokeOperation = m_transferTargetWatcher.TransferToAsync(target, windowId).AsTask();
    var result = await invokeOperation;

    if (result.Succeeded)
    {
        Console.WriteLine("Invoke successful");
    }
    else
    {
        // Log or handle the HRESULT error from result.ExtendedError
        Console.WriteLine($"Invoke failed with error: {result.ExtendedError}");
    }
}
```
