namespace Producer
{
    /// <summary>
    /// Producer configuration class
    /// </summary>
    public class ProducerConfiguration
    {
        /// <summary>
        /// Contains a path to the source of reports
        /// </summary>
        public string ReportsSource { get; set; }

        /// <summary>
        /// The interval between sending logs in milliseconds
        /// </summary>
        public long ReportsSendingInterval { get; set; }

        /// <summary>
        /// Message broker host
        /// </summary>
        public string RabbitMqHost { get; set; }
    }
}