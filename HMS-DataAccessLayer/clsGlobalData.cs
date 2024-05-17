using System;
using System.Diagnostics;

namespace HMS_DataAccessLayer
{
    public class clsGlobalData
    {
        public static void WriteExceptionInLogFile(Exception ex)
        {
            string sourceName = "HospitalsManagementsSystem";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Error);
        }
    }
}
