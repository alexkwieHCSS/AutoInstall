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
    ///The ValidateEstimateRecapOutput recording.
    /// </summary>
    [TestModule("a659b5a2-5b39-4d89-ae70-36aa7d420821", ModuleType.Recording, 1)]
    public partial class ValidateEstimateRecapOutput : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ValidateEstimateRecapOutput instance = new ValidateEstimateRecapOutput();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateEstimateRecapOutput()
        {
            ScriptLocation = "W:\\HBDaily\\InstallAutomation\\Script";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateEstimateRecapOutput Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScriptLocation;

        /// <summary>
        /// Gets or sets the value of variable ScriptLocation.
        /// </summary>
        [TestVariable("b18e9918-f8f0-4d2c-aa9e-7eb5e51568fa")]
        public string ScriptLocation
        {
            get { return _ScriptLocation; }
            set { _ScriptLocation = value; }
        }

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

            Report.Log(ReportLevel.Info, "Application", "Run application 'runEstimateRecap.bat' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("runEstimateRecap.bat", "", ScriptLocation, false);
            Delay.Milliseconds(0);
            
            EstimateRecapExists();
            Delay.Milliseconds(0);
            
            ValidateContentEstimateRecap();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
