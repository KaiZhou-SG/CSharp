using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace createWorkSpaceDaily
{
    /*
     * 2013-09-16 Zhou Kai adds comments:
     * This program is to create a work folder
     * every day when turning on this computer.
     */
    internal class Program
    {
        #region "private members"
        private const string workSpaceRoot = @"d:\workLog";
        #endregion

        public static void Main (string[] args)
        {
            Program pgm = new Program();
            DateTime dt = DateTime.Today;
            string workSpacePath = String.Empty;

            workSpacePath = workSpaceRoot + "\\" + pgm.FormatDate(dt);
            pgm.CreateWorkSpace(workSpacePath);
            Process.Start("explorer.exe", "/select," + workSpacePath);
            Process.Start("explorer.exe", "/select," + @"d:\ebooks");
            Process.Start("explorer.exe", "/select," + @"C:\FreightMaster80");

            return;
        }

        /*
         * 2013-09-16 Zhou Kai adds comments:
         * FormatDate() is to format a 
         * DateTime variable to a corresponding
         * string variable to serve as the
         * workspace folder name. 
         * 
         * For example:
         * 2013/09/16 12:00:00 AM is formated
         * to: 2013-09-16, and that will be the
         * folder name to be created.
         * 2013-09-16 ends
         */
        public string FormatDate(DateTime dt)
        {
            string rtn = String.Empty;
            rtn = dt.Year.ToString () + "-" + 
                  dt.Month.ToString() + "-" + dt.Day.ToString();

            return rtn;
        }

        /*
         * 2013-09-16 Zhou Kai adds comments:
         * CreateWorkSpace is to create a workspace
         * folder under the path: workSpacePath
         * 2013-09-16 ends
         */
        public bool CreateWorkSpace (string workSpacePath)
        {
            try
            {
                if (!Directory.Exists (workSpacePath))
                {
                    Directory.CreateDirectory (workSpacePath);
                    Console.WriteLine("The workspace is created for you.\n" +
                                      "Have a nice day~!");
                    Console.Read();
                    return true;
                }
                else
                {
                    Console.WriteLine ("The workspace: " + 
                                       workSpacePath + " already exists.\n" +
                                       "Have a nice day~!");
                    Console.Read ();
                    return false;
                }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("Exception: " + dnfe.Message + 
                                   "\nhave a nice day~!");
                Console.Read ();
                return false;
            }
        }
    }
}
