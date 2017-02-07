//<SnippetResourceProceduralGet>
    void MainPage::SetBGByResource(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
    {
      Button^ b = safe_cast<Windows::UI::Xaml::Controls::Button^>(sender);
      b->Background = safe_cast<Windows::UI::Xaml::Media::Brush^>(this->Resources->Lookup("RainbowBrush"));
    }
//</SnippetResourceProceduralGet>
