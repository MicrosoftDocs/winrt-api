---
-api-id: E:Windows.ApplicationModel.Core.CoreApplicationView.HostedViewClosing
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HostedViewClosing<Windows.ApplicationModel.Core.CoreApplicationView,  Windows.ApplicationModel.Core.HostedViewClosingEventArgs>
-->

# Windows.ApplicationModel.Core.CoreApplicationView.HostedViewClosing

## -description

Indicates that the hosted view is closing. Provides an opportunity for hosted window scenarios to defer the tear down of the hosted view.

## -remarks

Handling this event provides an opportunity to perform cleanup tasks such as closing files, flushing buffers to disk, and so on.

## -examples

The following example shows how to handle the **HostedViewClosing** event to perform cleanup tasks when a hosted view is closing. The example demonstrates using a deferral to allow asynchronous cleanup operations to complete before the view is torn down.

```csharp
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using System.Threading.Tasks;

public class HostedViewManager
{
    private CoreApplicationView hostedView;

    public void InitializeHostedView()
    {
        // Get or create a hosted view
        hostedView = CoreApplication.CreateNewView();
        
        // Subscribe to the HostedViewClosing event
        hostedView.HostedViewClosing += OnHostedViewClosing;

        // TODO: Add code to initialize the hosted view and switch to it
    }

    private async void OnHostedViewClosing(CoreApplicationView sender, HostedViewClosingEventArgs args)
    {
        // Get a deferral to perform async cleanup operations
        var deferral = args.GetDeferral();
        
        try
        {
            // Perform cleanup tasks such as:
            // - Saving unsaved data
            // - Closing file handles
            // - Flushing buffers to disk
            // - Releasing resources
            
            await SavePendingDataAsync();
            await CloseOpenFilesAsync();
            await FlushBuffersAsync();
        }
        finally
        {
            // Complete the deferral to allow the view to be torn down
            deferral.Complete();
        }
    }

    private async Task SavePendingDataAsync()
    {
        // TODO: Save any unsaved data before the view closes
        // Implementation depends on your application's needs
        await Task.Delay(100); // Placeholder for actual save operation
    }

    private async Task CloseOpenFilesAsync()
    {
        // TODO: Close any open file handles
        // Implementation depends on your application's file handling
        await Task.Delay(50); // Placeholder for actual file closing
    }

    private async Task FlushBuffersAsync()
    {
        // TODO: Flush any pending writes to disk
        // Implementation depends on your application's I/O operations
        await Task.Delay(25); // Placeholder for actual buffer flushing
    }
}
```

The following example shows how to handle the **HostedViewClosing** event in C++/WinRT to perform cleanup tasks when a hosted view is closing.

```cpp
#include <winrt/Windows.ApplicationModel.Core.h>
#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.Foundation.Collections.h>

using namespace winrt;
using namespace Windows::ApplicationModel::Core;
using namespace Windows::Foundation;

class HostedViewManager
{
private:
    CoreApplicationView m_hostedView{ nullptr };
    event_token m_hostedViewClosingToken{};

public:
    void InitializeHostedView()
    {
        // Get or create a hosted view
        m_hostedView = CoreApplication::CreateNewView();
        
        // Subscribe to the HostedViewClosing event
        m_hostedViewClosingToken = m_hostedView.HostedViewClosing(
            { this, &HostedViewManager::OnHostedViewClosing });

        // TODO: Add code to initialize the hosted view and switch to it
    }

    ~HostedViewManager()
    {
        // Unsubscribe from the event when the manager is destroyed
        if (m_hostedView && m_hostedViewClosingToken.value != 0)
        {
            m_hostedView.HostedViewClosing(m_hostedViewClosingToken);
        }
    }

private:
    IAsyncAction OnHostedViewClosing(CoreApplicationView const& sender, 
                                   HostedViewClosingEventArgs const& args)
    {
        // Get a deferral to perform async cleanup operations
        auto deferral = args.GetDeferral();
        
        try
        {
            // Perform cleanup tasks such as:
            // - Saving unsaved data
            // - Closing file handles
            // - Flushing buffers to disk
            // - Releasing resources
            
            co_await SavePendingDataAsync();
            co_await CloseOpenFilesAsync();
            co_await FlushBuffersAsync();
        }
        catch (...)
        {
            // Handle any exceptions during cleanup
            // Log the error or perform error handling as needed
        }
        
        // Complete the deferral to allow the view to be torn down
        deferral.Complete();
    }

    IAsyncAction SavePendingDataAsync()
    {
        // TODO: Save any unsaved data before the view closes
        // Implementation depends on your application's needs
        co_await winrt::resume_after(std::chrono::milliseconds(100));
    }

    IAsyncAction CloseOpenFilesAsync()
    {
        // TODO: Close any open file handles
        // Implementation depends on your application's file handling
        co_await winrt::resume_after(std::chrono::milliseconds(50));
    }

    IAsyncAction FlushBuffersAsync()
    {
        // TODO: Flush any pending writes to disk
        // Implementation depends on your application's I/O operations
        co_await winrt::resume_after(std::chrono::milliseconds(25));
    }
};
```

Note that the examples demonstrate the important pattern of using `GetDeferral()` to defer the view teardown until cleanup operations are complete. This is essential when performing asynchronous operations in the event handler, as it ensures the hosted view's window, dispatcher, and Application Single-Threaded Apartment (ASTA) thread are not torn down prematurely.

## -see-also
