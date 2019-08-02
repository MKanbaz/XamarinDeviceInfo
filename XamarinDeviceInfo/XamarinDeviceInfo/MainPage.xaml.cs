using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinDeviceInfo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Device Model (GT-850, iPhone10,6)
            // Cihazın Modeli
            var device = DeviceInfo.Model;
            DeviceModel.Text = "Device Model : " + device;

            // Manufacturer (Samsung, Xiaomi)
            // Cihazın Markası / Üreticisi
            var manufacturer = DeviceInfo.Manufacturer;
            DeviceManufacturer.Text = "Device Manufacturer : " + manufacturer;
            // Device Name (Xiaomi Note 7, iPhone 7)
            // Cihazın Adı
            var deviceName = DeviceInfo.Name;
            DeviceName.Text = "Device Name : " + deviceName;
            // Operating System Version Number (7.0)
            // Cihazın Sürümüs
            var version = DeviceInfo.VersionString;
            DeviceVersion.Text = "Device Version : " + version;
            // Platform (Android, İos)
            // Cihazın işletim sistemi
            var platform = DeviceInfo.Platform;
            DevicePlatform.Text = "Device Platform : " + platform.ToString();
            // Idiom (Phone, Tablet)
            // Cihaz Türü
            var idiom = DeviceInfo.Idiom;
            DeviceIdiom.Text = "Device İdiom : " + idiom.ToString();
        }
    }
}
