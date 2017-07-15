using Android.App;
using Android.Widget;
using Android.OS;


namespace XamarinFirebase
{
    [Activity(Label = "XamarinFirebase", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        } public override bool  OnCreateOptionsMenu (IMenu menu)
        { ManuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}
  
