using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Facebook_app
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public static AppSettings LoadFromFile()
        {
            AppSettings loadAppSettings = new AppSettings();

            if (File.Exists(@"D:\appSettings.xml"))
            {
                using (FileStream stream = new FileStream(@"D:\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadAppSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return loadAppSettings;
        }

        public void SaveToFile()
        {
            using (FileStream stream = new FileStream(@"D:\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}