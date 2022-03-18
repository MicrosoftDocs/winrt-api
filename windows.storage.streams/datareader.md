---
-api-id: T:Windows.Storage.Streams.DataReader
-api-type: winrt class
---

<!-- Class syntax.
public class DataReader : Windows.Foundation.IClosable, Windows.Storage.Streams.IDataReader
-->

# Windows.Storage.Streams.DataReader

## -description

Reads data from an input stream.

## -remarks

Instances of DataReader objects do not support concurrent read operations. If an application concurrently reads or detaches a stream from a DataReader instance that is being read from, the call to the object will fail with the error HRESULT_FROM_WIN32(ERROR_INVALID_OPERATION).

## -examples

The following code example shows how to write and read strings to an in-memory stream. For the full sample application in C# and in C++/CX, see [Serializing and deserializing data sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DataReaderWriter).

```csharp
using System;
using System.Diagnostics;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// This is the click handler for the 'Copy Strings' button.  Here we will parse the
// strings contained in the ElementsToWrite text block, write them to a stream using
// DataWriter, retrieve them using DataReader, and output the results in the
// ElementsRead text block.
private async void TransferData(object sender, RoutedEventArgs e)
{
    // Initialize the in-memory stream where data will be stored.
    using (var stream = new Windows.Storage.Streams.InMemoryRandomAccessStream())
    {
        // Create the data writer object backed by the in-memory stream.
        using (var dataWriter = new Windows.Storage.Streams.DataWriter(stream))
        {
            dataWriter.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf8;
            dataWriter.ByteOrder = Windows.Storage.Streams.ByteOrder.LittleEndian;

            // Parse the input stream and write each element separately.
            string[] inputElements = ElementsToWrite.Text.Split(';');
            foreach (string inputElement in inputElements)
            {
                uint inputElementSize = dataWriter.MeasureString(inputElement);
                dataWriter.WriteUInt32(inputElementSize);
                dataWriter.WriteString(inputElement);
            }

            // Send the contents of the writer to the backing stream.
            await dataWriter.StoreAsync();

            // For the in-memory stream implementation we are using, the flushAsync call 
            // is superfluous,but other types of streams may require it.
            await dataWriter.FlushAsync();

            // In order to prolong the lifetime of the stream, detach it from the 
            // DataWriter so that it will not be closed when Dispose() is called on 
            // dataWriter. Were we to fail to detach the stream, the call to 
            // dataWriter.Dispose() would close the underlying stream, preventing 
            // its subsequent use by the DataReader below.
            dataWriter.DetachStream();
        }

        // Create the input stream at position 0 so that the stream can be read 
        // from the beginning.
        using (var inputStream = stream.GetInputStreamAt(0))
        {
            using (var dataReader = new Windows.Storage.Streams.DataReader(inputStream))
            {
                // The encoding and byte order need to match the settings of the writer 
                // we previously used.
                dataReader.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf8;
                dataReader.ByteOrder = Windows.Storage.Streams.ByteOrder.LittleEndian;

                // Once we have written the contents successfully we load the stream.
                await dataReader.LoadAsync((uint)stream.Size);

                var receivedStrings = "";

                // Keep reading until we consume the complete stream.
                while (dataReader.UnconsumedBufferLength > 0)
                {
                    // Note that the call to readString requires a length of "code units" 
                    // to read. This is the reason each string is preceded by its length 
                    // when "on the wire".
                    uint bytesToRead = dataReader.ReadUInt32();
                    receivedStrings += dataReader.ReadString(bytesToRead) + "\n";
                }

                // Populate the ElementsRead text block with the items we read 
                // from the stream.
                ElementsRead.Text = receivedStrings;
            }
        }
    }
}
```

```cppwinrt
#include "pch.h"
#include "WriteReadStream.h" // header file for WriteReadStream.xaml.
#include <sstream>

#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.Storage.Streams.h>

using namespace winrt;

std::array<winrt::hstring, 5> m_inputElements{ L"Hello", L"World", L"1 2 3 4 5", L"Très bien!", L"Goodbye" };

WriteReadStream::WriteReadStream()
{
    InitializeComponent();

    // Populate the text block with the input elements.
    std::wstringstream stringstream;
    for (winrt::hstring const& element : m_inputElements)
    {
        stringstream << element.c_str() << L";";
    }
    ElementsToWrite().Text(stringstream.str().c_str());
}

// This is the click handler for the 'Copy Strings' button. Here we will parse the
// strings contained in the ElementsToWrite text block, write them to a stream using
// DataWriter, retrieve them using DataReader, and output the results in the
// ElementsRead text block.
winrt::Windows::Foundation::IAsyncAction WriteReadStream::TransferData(
    Windows::Foundation::IInspectable const& /* sender */,
    Windows::UI::Xaml::RoutedEventArgs const& /* args */)
{
    // Initialize the in-memory stream where data will be stored.
    Windows::Storage::Streams::InMemoryRandomAccessStream stream;

    // Create the DataWriter object backed by the in-memory stream. When
    // dataWriter goes out of scope, it closes the underlying stream.
    Windows::Storage::Streams::DataWriter dataWriter{ stream };
    dataWriter.UnicodeEncoding(Windows::Storage::Streams::UnicodeEncoding::Utf16LE);
    dataWriter.ByteOrder(Windows::Storage::Streams::ByteOrder::LittleEndian);

    // Create the data reader by using the input stream set at position 0 so that 
    // the stream will be read from the beginning regardless of the position that
    // the original stream ends up in after the store.
    Windows::Storage::Streams::IInputStream inputStream{ stream.GetInputStreamAt(0) };
    Windows::Storage::Streams::DataReader dataReader{ inputStream };
    // The encoding and byte order need to match the settings of the writer that
    // we previously used.
    dataReader.UnicodeEncoding(Windows::Storage::Streams::UnicodeEncoding::Utf16LE);
    dataReader.ByteOrder(Windows::Storage::Streams::ByteOrder::LittleEndian);

    // Write the input data to the output stream. Serialize the elements by writing
    // each string separately, preceded by its length in bytes.
    for (winrt::hstring const& element : m_inputElements)
    {
        dataWriter.WriteUInt32(element.size());
        dataWriter.WriteString(element);
    }

    // Send the contents of the writer to the backing stream.
    unsigned int bytesStored{ co_await dataWriter.StoreAsync() };

    // For the in-memory stream implementation we are using, the FlushAsync() call 
    // is superfluous, but other types of streams may require it.
    if (co_await dataWriter.FlushAsync())
    {
        try
        {
            // Once we've written the contents successfully, we load the stream.
            unsigned int bytesLoaded{ co_await dataReader.LoadAsync((unsigned int)stream.Size()) };

            std::wstringstream readFromStream;

            // Keep reading until we consume the complete stream.
            while (dataReader.UnconsumedBufferLength() > 0)
            {
                // Note that the call to ReadString requires a length of 
                // "code units" to read. This is the reason each string is 
                // preceded by its length when "on the wire".
                unsigned int bytesToRead{ dataReader.ReadUInt32() };
                readFromStream << dataReader.ReadString(bytesToRead).c_str() << std::endl;
            }

            // Populate the ElementsRead text block with the items we read from the stream
            ElementsRead().Text(readFromStream.str().c_str());
        }
        catch (winrt::hresult_error const& ex)
        {
            ElementsRead().Text(L"Error: " + ex.message());
        }
    }
}
```

```cppcx
#include "pch.h"
#include "WriteReadStream.xaml.h"

using namespace Concurrency;
using namespace DataReaderWriter;
using namespace Platform;
using namespace Windows::Storage::Streams;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;

Array<String^>^ _inputElements = ref new Array<String^>
{
    "Hello", "World", "1 2 3 4 5", "Très bien!", "Goodbye"
};

WriteReadStream::WriteReadStream()
{
    InitializeComponent();

    // Populate the text block with the input elements.
    ElementsToWrite->Text = "";
    for (unsigned int i = 0; i < _inputElements->Length; i++)
    {
        ElementsToWrite->Text += _inputElements[i] + ";";
    }
}

// Invoked when this page is about to be displayed in a Frame.
void WriteReadStream::OnNavigatedTo(NavigationEventArgs^ e)
{
    // Get a pointer to our main page.
    rootPage = MainPage::Current;
}

// This is the click handler for the 'Copy Strings' button.  Here we will parse the
// strings contained in the ElementsToWrite text block, write them to a stream using
// DataWriter, retrieve them using DataReader, and output the results in the
// ElementsRead text block.
void DataReaderWriter::WriteReadStream::TransferData(
Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    // Initialize the in-memory stream where data will be stored.
    InMemoryRandomAccessStream^ stream = ref new InMemoryRandomAccessStream();

    // Create the DataWriter object backed by the in-memory stream.  When
    // dataWriter is deleted, it will also close the underlying stream.
    DataWriter^ dataWriter = ref new DataWriter(stream);
    dataWriter->UnicodeEncoding = UnicodeEncoding::Utf8;
    dataWriter->ByteOrder = ByteOrder::LittleEndian;

    // Create the data reader by using the input stream set at position 0 so that 
    // the stream will be read from the beginning regardless of where the position
    // the original stream ends up in after the store.
    IInputStream^ inputStream = stream->GetInputStreamAt(0);
    DataReader^ dataReader = ref new DataReader(inputStream);
    // The encoding and byte order need to match the settings of the writer 
    // we previously used.
    dataReader->UnicodeEncoding = UnicodeEncoding::Utf8;
    dataReader->ByteOrder = ByteOrder::LittleEndian;

    // Write the input data to the output stream.  Serialize the elements by writing
    // each string separately, preceded by its length.
    for (unsigned int i = 0; i < _inputElements->Length; i++) 
    {
        unsigned int inputElementSize = dataWriter->MeasureString(_inputElements[i]);
        dataWriter->WriteUInt32(inputElementSize);
        dataWriter->WriteString(_inputElements[i]);
    }

    // Send the contents of the writer to the backing stream.
    create_task(dataWriter->StoreAsync()).then([this, dataWriter] (unsigned int bytesStored)
    {
        // For the in-memory stream implementation we are using, the FlushAsync() call 
        // is superfluous, but other types of streams may require it.
        return dataWriter->FlushAsync();
    }).then([this, dataReader, stream] (bool flushOp)
    {
        // Once we have written the contents successfully we load the stream.
        return dataReader->LoadAsync((unsigned int) stream->Size);
    }).then([this, dataReader] (task<unsigned int> bytesLoaded)
    {
        try
        {
            // Check for possible exceptions that could have been thrown 
            // in the async call chain.
            bytesLoaded.get();

            String^ readFromStream = "";

            // Keep reading until we consume the complete stream.
            while (dataReader->UnconsumedBufferLength > 0)
            {
                // Note that the call to ReadString requires a length of 
                // "code units" to read. This is the reason each string is 
                // preceded by its length when "on the wire".
                unsigned int bytesToRead = dataReader->ReadUInt32();
                readFromStream += dataReader->ReadString(bytesToRead) + "\n";
            }

            // Populate the ElementsRead text block with the items we read from the stream
            ElementsRead->Text = readFromStream;
        }
        catch (Exception^ e)
        {
            ElementsRead->Text = "Error: " + e->Message;
        }
    });
}
```

## -see-also

[Serializing and deserializing data sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DataReaderWriter), [File access sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess), [StreamSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/StreamSocket), [Custom USB device sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomUsbDeviceAccess), [DatagramSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket), [DataReaderLoadOperation](datareaderloadoperation.md), [DataWriter](datawriter.md)
