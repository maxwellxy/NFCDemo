
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Nfc;
using Poz1.NFCForms.Droid;
using Poz1.NFCForms.Abstract;
using Android.Media;

namespace NFCDemo.Droid
{
	[Activity (Label = "SecondActivity")]		
	[IntentFilter (new[]{NfcAdapter.ActionTagDiscovered},Categories = new[]{Intent.CategoryDefault})]
	public class SecondActivity : Activity
	{
		public NfcAdapter NFCdevice;
		public NfcForms x;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			NfcManager NfcManager = (NfcManager)Android.App.Application.Context.GetSystemService(Context.NfcService);
			NFCdevice = NfcManager.DefaultAdapter;

			x = Xamarin.Forms.DependencyService.Get<INfcForms>() as NfcForms;
			// Create your application here

			Intent CurrentIntent = this.Intent;
			Bundle bundle = CurrentIntent.Extras;

			foreach (string key in bundle.KeySet()) 
			{
				Object value = bundle.Get(key);
				Console.WriteLine("Key: "+key+" , value: "+value.ToString() +" , value class: "+value.GetType().Name);
			}
		}



		protected override void OnPause()
		{
			base.OnPause();
			NFCdevice.DisableForegroundDispatch(this);
		}

	}
}

