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
    ///The InstallWelcomeSQL recording.
    /// </summary>
    [TestModule("3f1ae4a1-f43b-49e5-953c-c9cd46fe916b", ModuleType.Recording, 1)]
    public partial class InstallWelcomeSQL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static InstallWelcomeSQL instance = new InstallWelcomeSQL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallWelcomeSQL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallWelcomeSQL Instance
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
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 3m to exist. Associated repository item: 'SQLServerInstallation.SQLInstaller'", repo.SQLServerInstallation.SQLInstaller.SelfInfo, new ActionTimeout(180000), new RecordItemIndex(0));
                repo.SQLServerInstallation.SQLInstaller.SelfInfo.WaitForExists(180000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'CrystalInstallation.CrystalInstaller.NextButton' at Center.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(1));
                repo.CrystalInstallation.CrystalInstaller.NextButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
