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
    ///The WhatsNewButton recording.
    /// </summary>
    [TestModule("b7cf6cce-8c18-4a2f-afef-55e95e692e31", ModuleType.Recording, 1)]
    public partial class WhatsNewButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static WhatsNewButton instance = new WhatsNewButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WhatsNewButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WhatsNewButton Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.WhatsNewTab' at Center.", repo.HeavyBidApp.Tabs.WhatsNewTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.WhatsNewTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.WhatsNew.NewHeavyBidFeaturesButton' at Center.", repo.HeavyBidApp.Buttons.WhatsNew.NewHeavyBidFeaturesButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.WhatsNew.NewHeavyBidFeaturesButton.Click();
            Delay.Milliseconds(200);
            
            // E.6
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nE.6\r\nValidating AttributeContains (Text>'help.hcss.com') on item 'GoogleChrome.AddressBar'.", repo.GoogleChrome.AddressBarInfo, new RecordItemIndex(2));
                Validate.AttributeContains(repo.GoogleChrome.AddressBarInfo, "Text", "help.hcss.com", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // E.6
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nE.6\r\nValidating AttributeRegex (Title~'Article List') on item 'GoogleChrome.Tab'.", repo.GoogleChrome.TabInfo, new RecordItemIndex(3));
                Validate.AttributeRegex(repo.GoogleChrome.TabInfo, "Title", new Regex("Article List"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // E.6
            //Report.Log(ReportLevel.Info, "Application", "E.6\r\nClosing application containing item 'GoogleChrome'.", repo.GoogleChrome.SelfInfo, new RecordItemIndex(4));
            //Host.Current.CloseApplication(repo.GoogleChrome.Self, 10000);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
