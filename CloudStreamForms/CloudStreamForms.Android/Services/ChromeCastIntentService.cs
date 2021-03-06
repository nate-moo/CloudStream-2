﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CloudStreamForms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudStreamForms.Droid.Services
{

	[Service]
	public class ChromeCastIntentService : IntentService
	{
		public ChromeCastIntentService() : base("ChromeCastIntentService") { }

		protected override void OnHandleIntent(Android.Content.Intent intent)
		{
			string data = intent.Extras.GetString("data");
			try {
				switch (data) {
					case "play":
						MainChrome.PauseAndPlay(false);
						break;
					case "pause":
						MainChrome.PauseAndPlay(true);
						break;
					case "goforward":
						MainChrome.SeekMedia(30);
						break;
					case "goback":
						MainChrome.SeekMedia(-30);
						break;
					case "stop":
						//  MainChrome.StopCast();
						MainChrome.JustStopVideo();
						break;
					default:
						break;
				}
			}
			catch (Exception) {

			}
		}
	}
}