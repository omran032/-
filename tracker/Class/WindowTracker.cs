using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using tracker.Class;

class WindowTracker
{
    // استدعاء دالة من Windows API للحصول على النافذة الحالية (اللي المستخدم فاتحها الآن
    [DllImport("user32.dll")]
    static extern IntPtr GetForegroundWindow();

     [DllImport("user32.dll")]
    static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

     public static bool IsVisualStudioActive()
    {
        const int nChars = 256; // عدد الأحرف اللي رح نقرأها من عنوان النافذة
        StringBuilder Buff = new StringBuilder(nChars); // مكان نخزن فيه عنوان النافذة

        IntPtr handle = GetForegroundWindow(); // الحصول على مؤشر النافذة الحالية

        // إذا قدرنا نقرأ عنوان النافذة  يعني الدالة رجعت رقم أكبر من 0
        if (GetWindowText(handle, Buff, nChars) > 0)
        {
            string title = Buff.ToString().ToLower(); // تحويل العنوان لنص صغير لسهولة المقارنة

            ClsTrackingPrograms trackingPrograms = new ClsTrackingPrograms(title);
            return trackingPrograms.CheckTrackedPrograms();

            //// فحص إذا العنوان يحتوي على أسماء البرامج اللي بدنا نراقبها
            //return title.ToLower().Contains("studio")
            //    || title.ToLower().Contains("management studio")
            //    || title.ToLower().Contains("inno setup")
            //    || title.ToLower().Contains("word")
            //    || title.Contains("vmware");
        }

        return false; 
    }
}
