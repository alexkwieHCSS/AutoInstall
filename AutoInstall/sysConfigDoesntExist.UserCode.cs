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
using System.IO;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutoInstall
{
    public partial class SysConfigDoesntExist
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CheckSysConfigExists()
        {
        	string path = @"C:\HeavyBid\SYS\";
        	string config = @"Heavybid.exe.Config";
        	string badPath = @"C:\HeavyBid\BIN\";
        	
        	string pathCheck = Path.Combine(path,config);
        	string pathValidation = Path.Combine(badPath,config);
        	
        	
        	if (File.Exists(pathCheck))
			   {
        		Report.Failure("File Exist", "Fail! " + pathCheck + " exists!");
			   }
			else                  
			   {
				Report.Success("File Exist", "Success. " + pathCheck + " does not exists.");
			   }
			
			if (File.Exists(pathValidation))
			   {
        		Report.Success("File Exist", "Success. " + pathValidation + " exists.");
			   }
			else                  
			   {
				Report.Failure("File Exist", "Fail. " + pathValidation + " does not exist.");	
			   }
    
        }

    }
}