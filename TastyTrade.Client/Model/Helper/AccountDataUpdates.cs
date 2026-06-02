using System;
using System.Collections.Generic;
using TastyTrade.Client.Model.Response.Streaming;

namespace TastyTrade.Client.Model.Helper
{
    /// <summary>
    /// Defines account data updates connection status values.
    /// </summary>
    public enum AccountDataUpdatesConnectionStatus
    {
        /// <summary>
        /// Represents unknown.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Represents open.
        /// </summary>
        Open = 1,
        /// <summary>
        /// Represents fault.
        /// </summary>
        Fault = 2,
        /// <summary>
        /// Represents closed.
        /// </summary>
        Closed = 3
    }
    /// <summary>
    /// Represents the account data updates.
    /// </summary>
    public class AccountDataUpdates
    {
        /// <summary>
        /// Gets or sets the connection opened.
        /// </summary>
        public DateTime ConnectionOpened { get; set; }
        /// <summary>
        /// Gets or sets the last heartbeat received.
        /// </summary>
        public DateTime LastHeartbeatReceived { get; set; }
        /// <summary>
        /// Gets or sets the last order update received.
        /// </summary>
        public DateTime LastOrderUpdateReceived { get; set; }
        /// <summary>
        /// Gets or sets the connection status.
        /// </summary>
        public AccountDataUpdatesConnectionStatus ConnectionStatus { get; set; }
        /// <summary>
        /// Gets or sets the order updates.
        /// </summary>
        public Queue<StreamingAccountOrderUpdate> OrderUpdates { get; internal set; }

        /// <summary>
        /// Executes the account data updates operation.
        /// </summary>
        public AccountDataUpdates()
        {
            OrderUpdates = new Queue<StreamingAccountOrderUpdate>();
        }
    }
}
