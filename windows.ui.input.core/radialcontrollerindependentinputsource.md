---
-api-id: T:Windows.UI.Input.Core.RadialControllerIndependentInputSource
-api-type: winrt class
---

<!-- Class syntax.
public class RadialControllerIndependentInputSource 
-->

# Windows.UI.Input.Core.RadialControllerIndependentInputSource

## -description
Enables an app to handle radial controller input on the background thread.

## -remarks
Call [DispatcherQueueController.CreateOnDedicatedThread](../windows.system/dispatcherqueuecontroller_createondedicatedthread_660689653.md) to create the [DispatcherQueue](../windows.system/dispatcherqueue.md) on the background thread where the RadialControllerIndependentInputSource is instantiated. Access this [DispatcherQueue](../windows.system/dispatcherqueue.md) using the [RadialControllerIndependentInputSource.DispatcherQueue](radialcontrollerindependentinputsource_dispatcherqueue.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | DispatcherQueue |

## -examples
Here, we create a [DispatcherQueue](../windows.system/dispatcherqueue.md) on a dedicated background thread and then initialize a RadialControllerInpdependentInputSource object, which is created on the background thread.

```csharp
public void CreateCoreIndependentInputSourceSample() 
{ 
    // Create a new thread, initialize DispatcherQueueController, 
    // and run a DispatcherQueue event loop on it. 
    _queueController =  
        DispatcherQueueController.CreateOnDedicatedThread(); 
    _queue = _queueController.DispatcherQueue;  

    // This is the first TryEnqueue() after creating the DispatcherQueue 
    // callback is guaranteed to be invoked first despite priority on the 
    // newly created thread. 
    bool isQueued = _queue.TryEnqueue( () => 
        {
            // The RadialControllerIndependentInputSource will raise events 
            // on the thread that created it.  
            radialInput = 
                RadialControllerIndependentInputSource.CreateForView(view); 
            radialInput.Controller.ButtonClicked += OnButtonClicked; 
            radialInput.Controller.ButtonHeld += OnButtonHeld; 
            radialInput.Controller.ButtonPressed += OnButtonPressed;  

            // Add RadialControllerMenuItems for this controller. 
            AddMenuItems(radialInput.Controller) 
        });         

    if (!isQueued) 
    { 
        // throw exception as this callback is enqueued. 
    } 

    // Enqueuing future tasks to this thread can be done using the DispatcherQueue 
    // property in RadialControllerIndependentInputSource.
    bool isTaskQueued = radialInput.DispatcherQueue.TryEnqueue( () => 
        { 
            // TODO. 
        }); 
}  

private DispatcherQueueController _queueController; 
private DispatcherQueue _queue; 
private RadialControllerIndependentInputSource radialInput; 
```

## -see-also

