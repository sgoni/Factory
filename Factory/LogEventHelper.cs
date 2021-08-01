using System.Diagnostics;

namespace FactoryStandard
{
    public static class LogEventHelper
    {
        /// <summary>
        /// Escribe un mensaje directamente al LOG del SO del Windows.
        /// </summary>
        /// <param name="mensajeError"></param>
        /// <param name="type"></param>
        public static void WriteToLogEvent(string queue, string mensajeError, EventLogEntryType type, int id = 0)
        {
            string sLog = "Application"; // "APP_VEINSA";
            string sFuente = queue;
            EventSourceCreationData mySourceData = new EventSourceCreationData(string.Empty, string.Empty);

            // Crea una cola de monitoreo en el Event Log
            if (!EventLog.SourceExists(sLog))
            {
                EventSourceCreationData data = new EventSourceCreationData(sFuente, sLog);
                EventLog.CreateEventSource(data);
            }

            if (type == EventLogEntryType.Error)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Error, id);
            else if (type == EventLogEntryType.Information)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Information, id);
            else if (type == EventLogEntryType.Warning)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Warning, id);
        }

        /// <summary>
        /// Escribe un mensaje directamente al LOG del SO del Windows.
        /// </summary>
        /// <param name="mensajeError"></param>
        /// <param name="type"></param>
        public static void WriteToLogEvent(string mensajeError, EventLogEntryType type, string fuente = "APP_GNL", int id = 0)
        {
            string sLog = "Application"; // "APP_VEINSA";
            string sFuente = fuente;
            EventSourceCreationData mySourceData = new EventSourceCreationData(string.Empty, string.Empty);

            // Crea una cola de monitoreo en el Event Log
            if (!EventLog.SourceExists(sLog))
            {
                EventSourceCreationData data = new EventSourceCreationData(sFuente, sLog);
                EventLog.CreateEventSource(data);
            }

            if (type == EventLogEntryType.Error)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Error, id);
            else if (type == EventLogEntryType.Information)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Information, id);
            else if (type == EventLogEntryType.Warning)
                EventLog.WriteEntry(sFuente, mensajeError, EventLogEntryType.Warning, id);
        }
    }
}
