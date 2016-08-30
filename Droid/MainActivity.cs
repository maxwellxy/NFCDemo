using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Nfc;
using Poz1.NFCForms.Droid;
using Poz1.NFCForms.Abstract;
using Android.Media;

namespace NFCDemo.Droid
{
	[Activity (Label = "NFCDemo.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

	//[MetaData (NfcAdapter.ActionNdefDiscovered, Resource="@xml/nfc")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);


			Xamarin.Forms.DependencyService.Register<INfcForms, NfcForms>();

			LoadApplication (new App ());

			//BroadcastRingerReceiver RingerReceiver = new BroadcastRingerReceiver ();
			//
			//IntentFilter RingerFilter1 = new IntentFilter (NfcAdapter.ActionTagDiscovered);
			//IntentFilter RingerFilter2 = new IntentFilter (NfcAdapter.ActionNdefDiscovered);
			//IntentFilter RingerFilter3 = new IntentFilter (NfcAdapter.ActionTechDiscovered);
			//
			//RegisterReceiver (RingerReceiver, RingerFilter1);
			//RegisterReceiver (RingerReceiver, RingerFilter2);
			//RegisterReceiver (RingerReceiver, RingerFilter3);
		}
	}
	/*
	public class BroadcastRingerReceiver : BroadcastReceiver
	{
		public override void OnReceive (Context context, Intent intent)
		{
			
		}
	}
	*/

}

