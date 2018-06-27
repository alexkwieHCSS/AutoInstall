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
    ///The FeatureSelectionSQL recording.
    /// </summary>
    [TestModule("c53b61a1-a5c0-4b25-bb59-ac20871ae365", ModuleType.Recording, 1)]
    public partial class FeatureSelectionSQL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static FeatureSelectionSQL instance = new FeatureSelectionSQL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FeatureSelectionSQL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FeatureSelectionSQL Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SQLServerInstallation.SQLInstaller.NextButton'", repo.SQLServerInstallation.SQLInstaller.NextButtonInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.SQLServerInstallation.SQLInstaller.NextButtonInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SQLServerInstallation.SQLInstaller.NextButton' at Center.", repo.SQLServerInstallation.SQLInstaller.NextButtonInfo, new RecordItemIndex(1));
            repo.SQLServerInstallation.SQLInstaller.NextButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
