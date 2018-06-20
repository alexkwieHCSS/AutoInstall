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
    ///The CustomizedCrystalReport recording.
    /// </summary>
    [TestModule("62891f38-cf04-4408-9359-faea7ab15c9f", ModuleType.Recording, 1)]
    public partial class CustomizedCrystalReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static CustomizedCrystalReport instance = new CustomizedCrystalReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CustomizedCrystalReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CustomizedCrystalReport Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Report.CustomizedCrystalReportsButton' at Center.", repo.HeavyBidApp.Buttons.Report.CustomizedCrystalReportsButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Report.CustomizedCrystalReportsButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBDropDownOptions.BidProposalLaborAndMaterialUP' at Center.", repo.HBDropDownOptions.BidProposalLaborAndMaterialUPInfo, new RecordItemIndex(2));
            repo.HBDropDownOptions.BidProposalLaborAndMaterialUP.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.PrintCustomizedCrystalReports.OKButton' at Center.", repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.PrintCustomizedCrystalReports.OKButtonInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.PrintCustomizedCrystalReports.OKButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Title~'Bid Proposal: Labor and Material') on item 'HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview'.", repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview.SelfInfo, new RecordItemIndex(4));
            Validate.AttributeRegex(repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview.SelfInfo, "Title", new Regex("Bid Proposal: Labor and Material"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview.CloseXButton' at Center.", repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview.CloseXButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.FromReportsButton.CustomizedCrystalReports.CustomCrystalBidProposalPreview.CloseXButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
