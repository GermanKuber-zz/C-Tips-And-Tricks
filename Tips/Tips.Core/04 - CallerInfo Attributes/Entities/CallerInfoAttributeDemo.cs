using System.Runtime.CompilerServices;

namespace Tips.Core.Entities
{
    public class CallerInfoAttribute
    {
        public string WhoCalledMe([CallerMemberName] string callingMember = null)
        {
            return "Llamado por el miembro :  " + callingMember;
        }


        public string WhatFileCalledMe([CallerFilePath] string callingFile = null)
        {
            return "Llamado desde el archivo :  " + callingFile;
        }


        public string WhatLineCalledMe([CallerLineNumber] int callingLineNum = 0)
        {
            return "Llamado desde la linea : " + callingLineNum;
        }
    }
}