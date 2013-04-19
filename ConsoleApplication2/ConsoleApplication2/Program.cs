using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.Win32;
using GraspReportDsp;

namespace ConsoleApplication2
{
    class Program
    {      

        static void Main(string[] args)
        {
           try
            {
                if (!IsExist("Pos系统")) 
                {
                    RegPathForProductName("Pos系统"); // 注册产品路径 指定Carpabase.ocx所在路径
                }
                crReportDispatcherClass report = new crReportDispatcherClass();
                object rs = report.GetReportServiceDsp("Pos系统"); // 产品名称
                rs.GetType().InvokeMember("HidePosConfigPage", BindingFlags.InvokeMethod, null, rs, new object[] { 1 });
                rs.GetType().InvokeMember("ShowPosCfg", BindingFlags.InvokeMethod, null, rs, null);
                rs = null;
               
            }
            catch (Exception exception)
            { 
                throw exception;
            }
            Console.WriteLine("********************Full Screen Mode********************");
            Console.ReadLine();
        }

        public static bool IsExist(string strName)
        {
            try
            {
                bool exit = false;
                string[] subkeyNames;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey Report = hkml.OpenSubKey(@"SOFTWARE\Grasp\Carpa\Report", true);             
                subkeyNames = Report.GetValueNames();
                foreach (string keyName in subkeyNames)
                {
                    if (keyName == strName)
                    {
                        exit = true;
                        return exit;
                    }
                }
                return exit;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void RegPathForProductName(string strName)
        {
            try
            {             
                RegistryKey hkml = Registry.LocalMachine;                
                RegistryKey Report = hkml.OpenSubKey(@"SOFTWARE\Grasp\Carpa\Report", true);
                if(Report==null)
                    hkml.CreateSubKey(@"SOFTWARE\Grasp\Carpa\Report");
                Report = hkml.OpenSubKey(@"SOFTWARE\Grasp\Carpa\Report", true);
                Report.SetValue(strName, System.Environment.CurrentDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }
    }
}
