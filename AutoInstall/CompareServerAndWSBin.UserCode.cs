﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using System.IO;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutoInstall
{
    public partial class CompareServerAndWSBin
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidateWSComparison()
        {
            string dir = @"V:\alex.kwie\Script\Reports\";
            string file = @"WSdifference.txt";
            string path = Path.Combine(dir,file);
            
      		if (File.Exists(path))
			   {
        		Report.Success("File Exist", "Success! " + file + " exists!");
			   }
			else                  
			   {
				Report.Failure("File Exist", "Fail. " + file + " does not exists.");
			   }
        }

    }
}
