﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Global
{
    class Global
    {
        public enum transactionDirection
        {
            In = 0,
            Out = 1
        }

        public static Boolean checkForSQLInjection(string userInput)
        {
            bool isSQLInjection = false;
            string[] sqlCheckList = 
                {
                    "--",
                    ";--",
                    ";",
                    "/*",
                    "*/",
                    "@@",
                    "char",
                    "nchar",
                    "varchar",
                    "nvarchar",
                    "alter",
                    "begin",
                    "cast",
                    "create",
                    "cursor",
                    "declare",
                    "delete",
                    "drop",
                    "end",
                    "exec",
                    "execute",
                    "fetch",
                    "insert",
                    "kill",
                    "select",
                    "sys",
                    "sysobjects",
                    "syscolumns",
                    "table",
                    "update"
            };
            string CheckString = userInput.Replace("'", "''");
            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((CheckString.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                { 
                    isSQLInjection = true; 
                }
            }
            return isSQLInjection;
        }
    }
}
