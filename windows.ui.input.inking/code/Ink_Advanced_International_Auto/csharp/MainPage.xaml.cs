using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ink_Advanced_International_Auto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        InkRecognizerContainer inkRecognizerContainer;
        DispatcherTimer recoTimer;

        // <SnippetSetInitialStrokeAttributes>
        public MainPage()
        {
            this.InitializeComponent();

            // Set supported inking device types.
            inkCanvas.InkPresenter.InputDeviceTypes =
                Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                Windows.UI.Core.CoreInputDeviceTypes.Pen;

            // Set initial ink stroke attributes.
            InkDrawingAttributes drawingAttributes = new InkDrawingAttributes();
            drawingAttributes.Color = Windows.UI.Colors.Black;
            drawingAttributes.IgnorePressure = false;
            drawingAttributes.FitToCurve = true;
            inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);

            // Populate the recognizer combo box with installed recognizers.
            InitializeRecognizerList();

            // Listen for combo box selection.
            comboInstalledRecognizers.SelectionChanged += 
                comboInstalledRecognizers_SelectionChanged;

            // Listen for stroke events on the InkPresenter to 
            // enable dynamic recognition.
            // StrokesCollected is fired when the user stops inking by 
            // lifting their pen or finger, or releasing the mouse button.
            inkCanvas.InkPresenter.StrokesCollected += 
                inkCanvas_StrokesCollected;
            // StrokeStarted is fired when ink input is first detected.
            inkCanvas.InkPresenter.StrokeInput.StrokeStarted += 
                inkCanvas_StrokeStarted;

            // Timer to manage dynamic recognition.
            recoTimer = new DispatcherTimer();
            recoTimer.Interval = new TimeSpan(0, 0, 1);
            recoTimer.Tick += recoTimer_Tick;
        }

        // <SnippetDynamicRecognitionEventHandlers>
        // Handler for the timer tick event calls the recognition function.
        private void recoTimer_Tick(object sender, object e)
        {
            Recognize_Tick();
        }

        // Handler for the InkPresenter StrokeStarted event.
        // If a new stroke starts before the next timer tick event,
        // stop the timer as the new stroke is likely the continuation
        // of a single handwriting entry.
        private void inkCanvas_StrokeStarted(InkStrokeInput sender, PointerEventArgs args)
        {
            recoTimer.Stop();
        }

        // Handler for the InkPresenter StrokesCollected event.
        // Start the recognition timer when the user stops inking by 
        // lifting their pen or finger, or releasing the mouse button.
        // After one second of no ink input, recognition is initiated.
        private void inkCanvas_StrokesCollected(InkPresenter sender, InkStrokesCollectedEventArgs args)
        {
            recoTimer.Start();
        }
        // </SnippetDynamicRecognitionEventHandlers>

        // </SnippetSetInitialStrokeAttributes>

        // <SnippetChangeRecognizer>
        // Handle recognizer change.
        private void comboInstalledRecognizers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            inkRecognizerContainer.SetDefaultRecognizer((InkRecognizer)comboInstalledRecognizers.SelectedItem);
        }
        // </SnippetChangeRecognizer>

        // <SnippetInitializeRecognizerList>
        // Populate the recognizer combo box with installed recognizers.
        private void InitializeRecognizerList()
        {
            // <SnippetInkRecognizerContainer>
            // Create a manager for the handwriting recognition process.
            inkRecognizerContainer = new InkRecognizerContainer();
            // </SnippetInkRecognizerContainer>
            // <SnippetGetRecognizers>
            // Retrieve the collection of installed handwriting recognizers.
            IReadOnlyList<InkRecognizer> installedRecognizers = inkRecognizerContainer.GetRecognizers();
            // </SnippetGetRecognizers>
            // inkRecognizerContainer is null if a recognition engine is not available.
            if (!(inkRecognizerContainer == null))
            {
                comboInstalledRecognizers.ItemsSource = installedRecognizers;
            }
        }
        // </SnippetInitializeRecognizerList>

        // <SnippetRecognize_Tick>
        // Respond to timer Tick and initiate recognition.
        private async void Recognize_Tick()
        {
            // <SnippetGetStrokes>
            // Get all strokes on the InkCanvas.
            IReadOnlyList<InkStroke> currentStrokes = inkCanvas.InkPresenter.StrokeContainer.GetStrokes();
            // </SnippetGetStrokes>

            // Ensure an ink stroke is present.
            if (currentStrokes.Count > 0)
            {
                // inkRecognizerContainer is null if a recognition engine is not available.
                if (!(inkRecognizerContainer == null))
                {
                    // <SnippetRecognizeAsync>
                    // Recognize all ink strokes on the ink canvas.
                    IReadOnlyList<InkRecognitionResult> recognitionResults =
                        await inkRecognizerContainer.RecognizeAsync(
                            inkCanvas.InkPresenter.StrokeContainer,
                            InkRecognitionTarget.All);
                    // </SnippetRecognizeAsync>
                    // Process and display the recognition results.
                    if (recognitionResults.Count > 0)
                    {
                        // <SnippetGetTextCandidates>
                        string str = "Recognition result\n";
                        // Iterate through the recognition results.
                        foreach (InkRecognitionResult result in recognitionResults)
                        {
                            // Get all recognition candidates from each recognition result.
                            IReadOnlyList<string> candidates = result.GetTextCandidates();
                            str += "Candidates: " + candidates.Count.ToString() + "\n";
                            foreach (string candidate in candidates)
                            {
                                str += candidate + " ";
                            }
                        }
                        // Display the recognition candidates.
                        recognitionResult.Text = str;
                        // Clear the ink canvas once recognition is complete.
                        inkCanvas.InkPresenter.StrokeContainer.Clear();
                        // </SnippetGetTextCandidates>
                    }
                    else
                    {
                        recognitionResult.Text = "No recognition results.";
                    }
                }
                else
                {
                    Windows.UI.Popups.MessageDialog messageDialog = new Windows.UI.Popups.MessageDialog("You must install handwriting recognition engine.");
                    await messageDialog.ShowAsync();
                }
            }
            else
            {
                recognitionResult.Text = "No ink strokes to recognize.";
            }

            // Stop the dynamic recognition timer.
            recoTimer.Stop();
        }
        // </SnippetRecognize_Tick>
    }
}
