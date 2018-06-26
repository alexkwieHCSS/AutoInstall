﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateXMLInstanceKey recording.
    /// </summary>
    [TestModule("d7ad1879-29dd-45c1-b888-80a6d59d0282", ModuleType.Recording, 1)]
    public partial class ValidateXMLInstanceKey : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ValidateXMLInstanceKey instance = new ValidateXMLInstanceKey();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateXMLInstanceKey()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateXMLInstanceKey Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nRun application 'Excel.EXE' with arguments 'C:\\ProgramData\\HCSS\\HeavyBid.xml' in normal mode.", new RecordItemIndex(0));
                Host.Local.RunApplication("Excel.EXE", "C:\\ProgramData\\HCSS\\HeavyBid.xml", "C:\\Program Files (x86)\\Microsoft Office", false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.OpenXML.xmlTable' at Center.", repo.ExcelRelated.OpenXML.xmlTableInfo, new RecordItemIndex(1));
                repo.ExcelRelated.OpenXML.xmlTable.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.OpenXML.OKButton' at Center.", repo.ExcelRelated.OpenXML.OKButtonInfo, new RecordItemIndex(2));
                repo.ExcelRelated.OpenXML.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.OKButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.OKButtonInfo, new RecordItemIndex(3));
                repo.ExcelRelated.ExcelXMLPopup.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.OfficeActivationSuite.CancelButton' at Center.", repo.ExcelRelated.OfficeActivationSuite.CancelButtonInfo, new RecordItemIndex(4));
                //repo.ExcelRelated.OfficeActivationSuite.CancelButton.Click();
                //Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // VARIABLE?
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nVARIABLE?\r\nValidating AttributeRegex (Text~'HEAVYMULT') on item 'ExcelRelated.Excel.CellA1'.", repo.ExcelRelated.Excel.CellA1Info, new RecordItemIndex(5));
                Validate.AttributeRegex(repo.ExcelRelated.Excel.CellA1Info, "Text", new Regex("HEAVYMULT"), null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nClosing application containing item 'ExcelRelated.Excel'.", repo.ExcelRelated.Excel.SelfInfo, new RecordItemIndex(6));
                Host.Current.CloseApplication(repo.ExcelRelated.Excel.Self, new Duration(0));
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.DontSaveButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.DontSaveButtonInfo, new RecordItemIndex(7));
                repo.ExcelRelated.ExcelXMLPopup.DontSaveButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
