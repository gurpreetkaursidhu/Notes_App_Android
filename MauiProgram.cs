﻿using CommunityToolkit.Maui;
using Keep_Notes_Android.ViewModel;
namespace Keep_Notes_Android;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();


        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<DetailViewModel>();



        return builder.Build();
	}
}
