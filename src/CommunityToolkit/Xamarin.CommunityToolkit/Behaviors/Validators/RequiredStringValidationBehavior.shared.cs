﻿using System.Threading;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Behaviors.Internals;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.Behaviors
{
	public class RequiredStringValidationBehavior : ValidationBehavior
	{
		public static readonly BindableProperty RequiredStringProperty
			= BindableProperty.Create(nameof(RequiredString), typeof(string), typeof(RequiredStringValidationBehavior));

		public string RequiredString
		{
			get => (string)GetValue(RequiredStringProperty);
			set => SetValue(RequiredStringProperty, value);
		}

		protected override Task<bool> ValidateAsync(object value, CancellationToken token)
			=> Task.FromResult(value?.ToString() == RequiredString);
	}
}