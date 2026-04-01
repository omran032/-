using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Guna.UI2.WinForms;

using static tracker.Class.FrmSettings;

namespace tracker.Class
{

    /// <summary>
    /// كلاس يحتوي نطقة إدارة البرامج المتتبعة
    /// </summary>
    internal class ClsTrackingPrograms
    {
        public ClsTrackingPrograms()
        {
        }

        public ClsTrackingPrograms(string title)
        {
            this.title = title;
            var refrech = TrackedPrograms;
        }
    

        public string title = "";
        public static string NewTrackedPrograms_ = "";

        public Dictionary<string, bool> TrackedPrograms
        {
            get
            {
                return new Dictionary<string, bool>
        {
            { "studio", FormSettings.chk_VS.Checked },
            { "code", FormSettings.chk_VSCode.Checked },
            { "android", FormSettings.Chk_AndroidStudio.Checked },
            { "webstorm", FormSettings.Chk_WebStrom.Checked },
            { "intellij", FormSettings.Chk_IntelliJ_IDEA.Checked },
            { "ssms", FormSettings.Chk_SQLServer.Checked },
            { "mysql", FormSettings.Chk_MySQL.Checked },
            { "mongodb", FormSettings.Chk_MangoDB.Checked },
            { "figma", FormSettings.Chk_Figma.Checked },
            { "photoshop", FormSettings.chk_Photoshop.Checked },
            { "office", FormSettings.Chk_Office.Checked },
            { "vmware", FormSettings.Chk_VMwere.Checked },
            { "copilot", FormSettings.Chk_Copilot.Checked },
            { "browser", FormSettings.Chk_Browsers.Checked },
            { "inno setup", FormSettings.Chk_InnoSetup.Checked }
        };
            }
        }


        List<string> browserKeywords = new List<string>
{
    "chrome",
    "edge",
    "firefox",
    "opera",
    "brave",
    "safari"
};

        /// <summary>
        /// فحص هل احد البرامج الشابقة مفتوحة ؟
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckTrackedPrograms()
        {
            bool result = false;

            foreach (var Tracked in TrackedPrograms)
            {
                string keyword = Tracked.Key;   // مثل: "studio"
                bool isChecked = Tracked.Value; // true أو false

                result = title.ToLower().Contains(keyword) && isChecked;
                if (result)
                    break;

            }

            return result || NewTrackedPrograms() || TrackedBrowser();
        }

        /// <summary>
        ///  فحص اذا المستخدم يريد تتبع برنامج آخر 
        ///  بشرط يجب ان يكون تم ادخاله
        /// </summary>
        /// <returns></returns>
       bool NewTrackedPrograms()
        {
            if(NewTrackedPrograms_ != "")
            return title.ToLower().Contains(NewTrackedPrograms_);

            return false;
        }


        /// <summary>
        /// فحص وتتبع كل انواع المتصفحات
        /// </summary>
        /// <returns></returns>
        bool TrackedBrowser()
        {
            string t = title.ToLower();

            return TrackedPrograms["browser"] &&
                   browserKeywords.Any(k => t.Contains(k));
        }


    }
}
