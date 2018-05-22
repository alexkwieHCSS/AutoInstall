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
    ///The BackupEstimate recording.
    /// </summary>
    [TestModule("550aa379-d749-40e8-8197-e320d9a479b4", ModuleType.Recording, 1)]
    public partial class BackupEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static BackupEstimate instance = new BackupEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BackupEstimate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BackupEstimate Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.File.BackupEstimateButton' at Center.", repo.HeavyBidApp.Buttons.File.BackupEstimateButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.File.BackupEstimateButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBDropDownOptions.SingleEstimate' at Center.", repo.HBDropDownOptions.SingleEstimateInfo, new RecordItemIndex(2));
            repo.HBDropDownOptions.SingleEstimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.EllipisisButton' at Center.", repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.EllipisisButtonInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.EllipisisButton.Click();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.GridViewOfEstimatesPopup.EstimateSearch.OKButton' at Center.", repo.HBPopUpScreens.GridViewOfEstimatesPopup.EstimateSearch.OKButtonInfo, new RecordItemIndex(4));
            //repo.HBPopUpScreens.GridViewOfEstimatesPopup.EstimateSearch.OKButton.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButton' at Center.", repo.HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.GridViewOfEstimatesPopup.ListOfEstimatesPopup.OKButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.FinishButton' at Center.", repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.FinishButtonInfo, new RecordItemIndex(6));
            repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupEstimate.FinishButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupExists.OKButton' at Center.", repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupExists.OKButtonInfo, new RecordItemIndex(7));
                repo.HBPopUpScreens.FromFileButtons.BackupEstimateRelated.BackupExists.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
