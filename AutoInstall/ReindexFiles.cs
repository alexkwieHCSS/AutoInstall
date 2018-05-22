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
    ///The ReindexFiles recording.
    /// </summary>
    [TestModule("8a5b70e5-0a39-4536-90fe-dc74cc71554b", ModuleType.Recording, 1)]
    public partial class ReindexFiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ReindexFiles instance = new ReindexFiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReindexFiles()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReindexFiles Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ToolsTab' at Center.", repo.HeavyBidApp.Tabs.ToolsTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ToolsTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Tools.ReindexFilesButton' at Center.", repo.HeavyBidApp.Buttons.Tools.ReindexFilesButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Tools.ReindexFilesButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'False' on item 'HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.CurrentEstimateCheckbox'.", repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.CurrentEstimateCheckboxInfo, new RecordItemIndex(2));
            repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.CurrentEstimateCheckbox.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.SystemFilesCheckbox'.", repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.SystemFilesCheckboxInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.SystemFilesCheckbox.Element.SetAttributeValue("Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.OKButton' at Center.", repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.OKButtonInfo, new RecordItemIndex(4));
            repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexScreen.OKButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexWarningScreen.OKButton' at Center.", repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexWarningScreen.OKButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.FromFileButtons.ReindexRelated.ReindexWarningScreen.OKButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
