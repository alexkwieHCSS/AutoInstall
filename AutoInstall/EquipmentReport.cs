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
    ///The EquipmentReport recording.
    /// </summary>
    [TestModule("96455a3d-5923-4b5b-be1f-5516c1ca1641", ModuleType.Recording, 1)]
    public partial class EquipmentReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static EquipmentReport instance = new EquipmentReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EquipmentReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EquipmentReport Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ReportTab' at Center.", repo.HeavyBidApp.Tabs.ReportTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ReportTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Report.CostReportsButton' at Center.", repo.HeavyBidApp.Buttons.Report.CostReportsButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Report.CostReportsButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HeavyBidApp.DocumentInterface.Reports.CostReports.EquipmentReport' at Center.", repo.HeavyBidApp.DocumentInterface.Reports.CostReports.EquipmentReportInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Reports.CostReports.EquipmentReport.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Title~'Equipment') on item 'HBReportViewers.HeavyBidPivotReports'.", repo.HBReportViewers.HeavyBidPivotReports.SelfInfo, new RecordItemIndex(4));
            Validate.AttributeRegex(repo.HBReportViewers.HeavyBidPivotReports.SelfInfo, "Title", new Regex("Equipment"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.HeavyBidPivotReports.CloseButton' at Center.", repo.HBReportViewers.HeavyBidPivotReports.CloseButtonInfo, new RecordItemIndex(5));
            repo.HBReportViewers.HeavyBidPivotReports.CloseButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
