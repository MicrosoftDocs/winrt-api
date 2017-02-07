#pragma once

namespace BaseElementEvents
{
	namespace Common
	{
		/// <summary>
		/// Implementation of <see cref="INotifyPropertyChanged"/> to simplify models.
		/// </summary>
		[Windows::Foundation::Metadata::WebHostHidden]
		public ref class BindableBase : Windows::UI::Xaml::Data::INotifyPropertyChanged
		{
		public:
			virtual event Windows::UI::Xaml::Data::PropertyChangedEventHandler^ PropertyChanged;

		protected:
			virtual void OnPropertyChanged(Platform::String^ propertyName);
		};
	}
}
