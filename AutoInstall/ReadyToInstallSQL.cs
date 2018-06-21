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
    ///The ReadyToInstallSQL recording.
    /// </summary>
    [TestModule("0e43be61-ce2b-40e9-916a-d6cba4419ec3", ModuleType.Recording, 1)]
    public partial class ReadyToInstallSQL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ReadyToInstallSQL instance = new ReadyToInstallSQL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReadyToInstallSQL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReadyToInstallSQL Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SQLServerInstallation.SQLInstaller.InstallButton' at Center.", repo.SQLServerInstallation.SQLInstaller.InstallButtonInfo, new RecordItemIndex(0));
            repo.SQLServerInstallation.SQLInstaller.InstallButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SQLServerInstallation.SQLInstaller.FinishButton'", repo.SQLServerInstallation.SQLInstaller.FinishButtonInfo, new ActionTimeout(10000), new RecordItemIndex(1));
            repo.SQLServerInstallation.SQLInstaller.FinishButtonInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SQLServerInstallation.SQLInstaller.FinishButton' at Center.", repo.SQLServerInstallation.SQLInstaller.FinishButtonInfo, new RecordItemIndex(2));
            repo.SQLServerInstallation.SQLInstaller.FinishButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
