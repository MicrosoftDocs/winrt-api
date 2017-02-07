//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace Windows_Media_SpeechSynthesis;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;
using namespace Windows::Media::SpeechSynthesis;
using namespace Concurrency;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238


MainPage::MainPage()
{
	InitializeComponent();
}

SpeechSynthesizer^ synth;
MediaElement^ media;

void Windows_Media_SpeechSynthesis::MainPage::Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	// <SnippetSpeechSynthesizerText>
	// The object for controlling the speech synthesis engine (voice).
	synth = ref new SpeechSynthesizer();
	// The media object for controlling and playing audio.
	media = ref new MediaElement();
	// The string to speak.
	String^ text = "Hello World";

	// Generate the audio stream from plain text.
	task<SpeechSynthesisStream ^> speakTask = create_task(synth->SynthesizeTextToStreamAsync(text));
	speakTask.then([this, text](SpeechSynthesisStream ^speechStream)
	{
		// Send the stream to the media object.
		// media === MediaElement XAML object.
		media->SetSource(speechStream, speechStream->ContentType);
		media->AutoPlay = true;
		media->Play();
	});
	// </SnippetSpeechSynthesizerText>
}

void Windows_Media_SpeechSynthesis::MainPage::Button_Click_1(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	// <SnippetSpeechSynthesizerSSML>
	// The object for controlling the speech synthesis engine (voice).
	synth = ref new SpeechSynthesizer();
	// The media object for controlling and playing audio.
	media = ref new MediaElement();
	// The string to speak.
	String^ ssml =
		"<speak version='1.0' "
		"xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>"
		"Hello <prosody contour='(0%,+80Hz) (10%,+80%) (40%,+80Hz)'>World</prosody>"
		"<break time='500ms' /> "
		"Goodbye <prosody rate='slow' contour='(0%,+20Hz) (10%,+30%) (40%,+10Hz)'>World</prosody>"
		"</speak>";

	// Generate the audio stream from SSML.
	task<SpeechSynthesisStream ^> speakTask = create_task(synth->SynthesizeSsmlToStreamAsync(ssml));
	speakTask.then([this, ssml](SpeechSynthesisStream ^speechStream)
	{
		// Send the stream to the media object.
		// media === MediaElement XAML object.
		media->SetSource(speechStream, speechStream->ContentType);
		media->AutoPlay = true;
		media->Play();
	});
	// </SnippetSpeechSynthesizerSSML>
}
