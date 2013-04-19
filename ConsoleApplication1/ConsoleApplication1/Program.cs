using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using GraspReportDsp;
using Microsoft.Win32;


namespace ConsoleApplication1
{
    class Program
    {
        [ComImport,
         ComVisible(false),
         InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
         Guid("00000001-0000-0000-C000-000000000046")]
        public interface IClassFactory
        {
            void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppvObject);
            void LockServer([MarshalAs(UnmanagedType.Bool)] bool fLock);
        }

        [Guid("0165E0CB-B4E2-4957-8AB7-8EE87D7D6174")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IReportService
        {
            [PreserveSig]
            //int Calculate(int i, double s);
            string Hello();
        }

      
        [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
        interface IcrPOSPrint
        {
             [PreserveSig]
            void PosBillPrint(int AppHandle,string DataFileName,string ModuleFileName,int PrintType,bool IsDesign);
             [PreserveSig]
            void CloseBillPrintHandle();
             [PreserveSig]
            void PosOpenCashBox();
             [PreserveSig]
            void PosScreenOut(int nType,string szMoney);
             [PreserveSig]
            void ShowPosCfg();
             [PreserveSig]
            void PosClose_prn();
             [PreserveSig]
            void HidePosCfgPage(int APageIndexr); 
            //Insert code here.
        }

        //[DllImport(@"PoPrintDll.dll")]
        //public static extern int Sub(int a,int b);

        //[DllImport(@"E:\trd\component\PoPrintDll\Debug\PoPrintDll.dll")]
        //public static extern IReportService GetCarpaBaseDsp();
        //[DllImport(@"E:\trd\component\PoPrintDll\Debug\PoPrintDll.dll")]
        //public static extern object GetCarpaBaseDsp1(out IReportService rs);

        //[DllImport(@"PoPrintDll.dll")]
        //public static extern void PosPrintTest();

        //[DllImport(@"CarpaBase.ocx")]
        //public static extern void Hello1();
        delegate int DllGetClassObject(ref Guid clsid, ref Guid rid, out IntPtr result);
        delegate string Hello();
        delegate int Sub(int a, int b);
        static void Main(string[] args)
        {
          
            crReportDispatcherClass cl = new crReportDispatcherClass();
            //object obj = cl.GetPosDriverDsp("产品名称");
            //obj.GetType().InvokeMember("HidePosCfgPage", BindingFlags.InvokeMethod, null, obj, new object[] { 1 });
            //obj.GetType().InvokeMember("ShowPosCfg", BindingFlags.InvokeMethod, null, obj, null);

            object obj1 = cl.GetReportServiceDsp("产品名称");
            object a = obj1.GetType().InvokeMember("ShowPosCfg", BindingFlags.InvokeMethod, null, obj1, null);
            
         //   MemberInfo[] m = obj.GetMethods(BindingFlags.Default);
          //  Marshal.get
           
            
           
            //v.GetMethod(
         // int i = Sub(1,4);
         //   Console.WriteLine(i);
          //  PosPrintTest();    
          //  IReportService rs = null;
          //  GetCarpaBaseDsp1(out rs);
          //  rs.Hello();
          //string s1=   GetCarpaBaseDsp().Hello();
          //  DllInvoke dll = new DllInvoke("CarpaBase.ocx");
            //DllInvoke dll = new DllInvoke(@"E:\trd\component\PoPrintDll\Debug\PoPrintDll.dll");
            //Sub s = (Sub)dll.Invoke("Sub", typeof(Sub));
            //Console.WriteLine(s(1, 2));
           //DllGetClassObject s = (DllGetClassObject)dll.Invoke("DllGetClassObject",typeof(DllGetClassObject));
           // IntPtr dllGetClassObjectPtr = dll.Invoke1("DllGetClassObject", typeof(DllGetClassObject));
          //  DllGetClassObject dllGetClassObject =
                       //    (DllGetClassObject)Marshal.GetDelegateForFunctionPointer(
                      //      dllGetClassObjectPtr, typeof(DllGetClassObject));

            
          //  Guid clsid = new Guid("41859F87-89ED-49DD-9D18-824313D22F08");
          //  Guid rid = new Guid("0165E0CB-B4E2-4957-8AB7-8EE87D7D6174");
         //   Guid IClassFactoryGUID = new Guid("00000001-0000-0000-C000-000000000046");
          //  IntPtr ptr = new IntPtr();
          //  object o1 = Marshal.GetObjectForIUnknown(ptr);

          //  if (dllGetClassObject(ref clsid,
           //        ref IClassFactoryGUID, out ptr) == 0)
          //  {

             //   object oo = Marshal.GetUniqueObjectForIUnknown(ptr); //Marshal.GetObjectForIUnknown(ptr);
                //()
              //  object value = oo.GetType().InvokeMember("Hello", BindingFlags.InvokeMethod, null, oo, null);
              
              
               // ReportService rs = new ReportService();
               // IReportService irs = rs as IReportService;      

             //   object irs = (ptr as IClassFactory).CreateInstance(irs, rid,out ptr);//Marshal.GetObjectForIUnknown(ptr);// as IReportService;
           //    irs.GetType().GetProperty("version");
               
              //object a =  Marshal.GetUniqueObjectForIUnknown(ptr);
              //  Type t = Type.GetTypeFromCLSID(clsid);
              // Type.GetTypeFromHandle(
               
               // object o = Marshal.GetUniqueObjectForIUnknown(ptr);
                //object s = o.GetType().InvokeMember("Hello", BindingFlags.Instance | BindingFlags.InvokeMethod,
                //  null,
                 // o,
                //  new object[]{} );
                //(ptr as IClassFactory).CreateInstance(unk, IClassFactoryGUID,out ptr);
             
             // IntPtr p;
             // factory.CreateInstance(unk, IClassFactoryGUID, out p);
                //object obj = Pointer.Box(unk.ToPointer(), typeof(ReportService*));
                //Delegate dl = Marshal.GetDelegateForFunctionPointer(unk, typeof(Hello));

              //  Hello hello = (Hello)Marshal.GetDelegateForFunctionPointer(unk, typeof(Hello));
              //  hello();
                //string s = hello.Invoke();
               
          //  }
          
             
            Console.WriteLine("********************Full Screen Mode********************");
            Console.ReadLine();
        }
        
        //public class ReportService : IReportService
        //{
        //    public string Hello()
        //    {
        //        return "xx";
        //    }
        //}

        

        public class DllInvoke
        {

            #region Win API
            [DllImport("kernel32.dll")]
            private extern static IntPtr LoadLibraryA(string path);

            [DllImport("kernel32.dll")]
            private extern static IntPtr GetProcAddress(IntPtr lib, string funcName);

            [DllImport("kernel32.dll")]
            private extern static bool FreeLibrary(IntPtr lib);
            #endregion


            private IntPtr hLib;
            public DllInvoke(String DLLPath)
            {
                hLib = LoadLibraryA(DLLPath);               
            }

            ~DllInvoke()
            {
                FreeLibrary(hLib);
            }

            //将要执行的函数转换为委托
            public Delegate Invoke(string APIName, Type t)
            {
                IntPtr api = GetProcAddress(hLib, APIName);     
                
                return (Delegate)Marshal.GetDelegateForFunctionPointer(api, t);
            }

            public IntPtr Invoke1(string APIName, Type t)
            {
                return GetProcAddress(hLib, APIName);
                
            }

        }

        //private static void WriteData(ReportServiceClass reportService, string tableName, int tableIndex, string[] fields, string[] rowData)
        //{
        //    reportService.AddDataTable(tableName);
        //    foreach (string field in fields)
        //    {
        //        reportService.AddDataColumn(tableIndex, field, 1);//ADataType 1 string,2 datetime,3 blob, other string
        //    }

        //    int rowIndex = 0;
        //    int columIndex = 0;
        //    foreach (string value in rowData)
        //    {
        //        if (columIndex % fields.Length == 0)
        //        {
        //            columIndex = 0;
        //            rowIndex++;
        //            reportService.AddDataRow(tableIndex);
        //        }
        //        reportService.SetRowStr(tableIndex, rowIndex - 1, columIndex, value);
        //        columIndex++;
        //    }

        //}

        //private static void CreateDataSet(ReportServiceClass reportService)
        //{
        //    string[] masterFields = { "公司名称", "公司地址", "邮编" };
        //    string[] masterRowData = { "任我行软件股份有限公司", "成都市天府大道天府软件园", "610000" };
        //    WriteData(reportService, "master", 0, masterFields, masterRowData);//表头表尾

        //    string[] detailFields = { "商品名称", "商品简名", "产地", "价格", "金额", "数量 " };
        //    string[] detailRowData = { "辉煌V2.2", "v2.2", "成都", "3210.00", "3210.00", "1", "财贸II", "财贸", "成都", "6111.00", "6111.00", "1" };
        //    WriteData(reportService, "detail", 1, detailFields, detailRowData);//表体

        //    string[] detailFields1 = { "商品名称1", "商品简名1", "产地1", "价格1", "金额1", "数量1 " };
        //    string[] detailRowData1 = { "辉煌V2.21", "v2.21", "成都1", "3210.00", "3210.00", "1", "财贸II", "财贸", "成都", "6111.00", "6111.00", "1" };
        //    WriteData(reportService, "detail1", 2, detailFields1, detailRowData1);//表体
        //}

       
    }
}
