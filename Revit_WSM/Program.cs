using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Revit_WSM
{
    class Program
    {
        static void Main(string[] args)
        {
#if REVIT_2015
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2015\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2015\\WorksharingMonitor.exe");
#elif REVIT_2016
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2016\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2016\\WorksharingMonitor.exe");
#elif REVIT_2017
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2017\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2017\\WorksharingMonitor.exe");
#elif REVIT_2018
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2018\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2018\\WorksharingMonitor.exe");
#elif REVIT_2019
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2019\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2019\\WorksharingMonitor.exe");
#elif REVIT_2020
            Process.Start("C:\\Program Files\\Autodesk\\Revit 2020\\Revit.exe");
            Process.Start("C:\\Program Files\\Autodesk\\Worksharing Monitor for Revit 2020\\WorksharingMonitor.exe");
#endif
        }
    }
}
