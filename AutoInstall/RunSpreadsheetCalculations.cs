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
    ///The RunSpreadsheetCalculations recording.
    /// </summary>
    [TestModule("876a05d5-6364-4981-8a07-566fcef62b75", ModuleType.Recording, 1)]
    public partial class RunSpreadsheetCalculations : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static RunSpreadsheetCalculations instance = new RunSpreadsheetCalculations();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunSpreadsheetCalculations()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunSpreadsheetCalculations Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.FileTab' at Center.", repo.HeavyBidApp.Tabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.File.OpenEstimateButton' at Center.", repo.HeavyBidApp.Buttons.File.OpenEstimateButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.File.OpenEstimateButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.Buttons.OKButton' at Center.", repo.HeavyBidApp.DocumentInterface.Buttons.OKButtonInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Buttons.OKButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.Buttons.ExpandAllTreeviewButton' at Center.", repo.HeavyBidApp.DocumentInterface.Buttons.ExpandAllTreeviewButtonInfo, new RecordItemIndex(3));
            repo.HeavyBidApp.DocumentInterface.Buttons.ExpandAllTreeviewButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableBiditem' at Center.", repo.HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableBiditemInfo, new RecordItemIndex(4));
            repo.HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableBiditem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.Buttons.SpreadsheetCalculationButton' at Center.", repo.HeavyBidApp.DocumentInterface.Buttons.SpreadsheetCalculationButtonInfo, new RecordItemIndex(5));
            repo.HeavyBidApp.DocumentInterface.Buttons.SpreadsheetCalculationButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.OpenEstimateRelated.SelectSpreadsheet.FirstAvailableCalculations' at Center.", repo.HBPopUpScreens.FromFileButtons.OpenEstimateRelated.SelectSpreadsheet.FirstAvailableCalculationsInfo, new RecordItemIndex(6));
            repo.HBPopUpScreens.FromFileButtons.OpenEstimateRelated.SelectSpreadsheet.FirstAvailableCalculations.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.SpreadsheetCalculationViewer.CloseButton' at Center.", repo.HBReportViewers.SpreadsheetCalculationViewer.CloseButtonInfo, new RecordItemIndex(7));
            repo.HBReportViewers.SpreadsheetCalculationViewer.CloseButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}