using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace ConsoleApplication1
{
     [ComImport, Guid("41859F87-89ED-49DD-9D18-824313D22F08")]
     public class ReportService 
      {
       
      }
    [ComImport, CoClass(typeof(ReportService)), Guid("0165E0CB-B4E2-4957-8AB7-8EE87D7D6174")]
    public interface IReportService
    {     
        int AddDataColumn(int ATableIndex, string AColumnName, int ADataType);
      
        int AddDataRow(int ATableIndex);
       
        int AddDataTable(string ATableName);
       
        int BarcodeConfig();
      
        void BeginDoc(int PrinterIndex);
        
        void BeginPage(int PrinterIndex);
     
        bool CarpaMultiTablePosPrint(string AModuleFileName, bool ADesign, int ADesignTableCount);
     
        void ClearDataset();
       
        void Close();
     
        string ConvertTemplate(string AFilename, string ATemplateName);
    
        string CopyFile(string AFromFilename, string AToFilename);
     
        void CopyTextToClipboard(string Text);
   
        bool DeleteTextFile(string FileName);
     
        void DrawText(int PrinterIndex, string Text, int X, int Y, int Width, int Height, bool TextWrapping);
      
        void Ellipse(int PrinterIndex, double x1, double y1, double x2, double y2);
   
        void EndDoc(int PrinterIndex);
       
        void EndPage(int PrinterIndex);
     
        void FillRect(int PrinterIndex, int Color, int X, int Y, int Width, int Height);
    
        IntPtr Get_BaseService();
    
        int GetBarcodePrintCount();
       
        string GetCaptureImage();
        
        string GetFontNames(int APrinterIndex);
   
        string GetOpenFileName(string Filter);
       
        int GetPosPrintCount();
      
        string GetPrinterBinNames(int PrinterIndex);
    
        string GetPrinterComment(int PrinterIndex);
  
        int GetPrinterDpiX(int PrinterIndex);
       
        int GetPrinterDpiY(int PrinterIndex);
     
        string GetPrinterDriverName(int PrinterIndex);
       
        int GetPrinterIndex();
 
        string GetPrinterPapers(int PrinterIndex);

        string GetPrinterPaperSize(int PrinterIndex, int paperIndex);
      
        double GetPrinterPhysicalOffsetX(int PrinterIndex);
       
        double GetPrinterPhysicalOffsetY(int PrinterIndex);
       
        string GetPrinterPortName(int PrinterIndex);
      
        int GetPrinterPrintCopys(int APrinterIndex);
       
        string GetPrinters();
 
        string GetPrinterStatus(int PrinterIndex);
      
        string GetSaveFileName(string defaultFilename, string Filter, string defaultExt);
        
        int GetScreenDpi(string productKey);
       
        string GetVersionInfo();        
      
        string Hello();        
     
        void HidePosConfigPage(int APageNum);
      
        void Image(int PrinterIndex, int X, int Y, int Width, int Height, string ImageData, int RenderStyle);
    
        void LineTo(int PrinterIndex, int X, int Y);
     
        string LoadBinaryFile(string FileName);
       
        string LoadTextFile(string FileName);
  
        void Log(string AMessage);
     
        int MeasureEnglishCharHeight(int APrinterIndex, string s, int AWidth, bool ATextWrapping);
     
        int MeasureTextHeight(int PrinterIndex, string s, int AWidth, bool ATextWrapping);
    
        int MeasureTextWidth(int PrinterIndex, string s);
    
        void MoveTextFile(string ExistingFileName, string NewFileName);
   
        void MoveTo(int PrinterIndex, int X, int Y);
      
        void MultiTableBillPrint(string AModulName, bool ADesign, int ATableCount);
      
        void OpenCashbox();
       
        void OpenDir(string ADir);
       
        void OpenExcelFile(string FileName);
    
        void PosPreview(int AWidth, string AModuleFileName, int ADesignTableCount);
       
        bool PosPrint(string AMudulFileName, bool ADesign);
       
        void PosScreenOut(int AType, string AMoney);
   
        void PrintBarcode(int ACopyCount);
      
        void ProcessMessages();
   
        void SaveBinaryFile(string FileName, string Base64Content);
       
        void SaveDatasetToFile();
       
        void SaveTextFile(string FileName, string Content);
     
        void SetBarPrintLimitTimes(int ALimitTimes);
        
        void SetFontStyle(int PrinterIndex, bool bold, bool italic, bool underline);
 
        void SetIsBarPrintLimit(bool AValue);
 
        void SetIsPosPrintLimit(bool AValue, bool AIsNewPos);
    
        void SetIsTransparence(bool AValue);
  
        void SetLineStyle(int PrinterIndex, int Width, int LineKind, int LineColor);
        
        void SetPosPrintLimitTimes(int ALimitTimes, bool AIsNewPos);
      
        void SetPrinterOffset(double offsetX, double offsetY, double offsetWidth, double offsetHeight);
       
        void SetPrinterPaper(int PrinterIndex, int paperIndex);
       
        void SetPrinterPaperOrientation(int APrinterIndex, int AOrientation);
       
        void SetPrinterPaperSize(int APrinterIndex, double AWidth, double AHeight);
     
        void SetRowBytes(int ATableIndex, int ARowIndex, int AColumnIndex, string ABase64);
    
        void SetRowStr(int ATableIndex, int ARowIndex, int AColumnIndex, string AValue);
       
        void SetTextAlign(int hAlign, int vAlign);
      
        void SetTextStyle(int PrinterIndex, string FontName, double FontSize, int FontColor);
     
        void ShowHelp();
     
        void ShowPosCfg();

        bool ShowPrinterPropertyDialog(int PrinterIndex);
       
        int SplitText(int PrinterIndex, string Text, int AvailableWidth, int AvailableHeight);
   
        void TestReceiveImage(string AData);
        
    }

    
}
