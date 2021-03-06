﻿using MEF.Launcher.Contract;
using PropertyChanged;
using System.ComponentModel.Composition;

namespace MEF.Launcher.ViewModels
{
    [Export(typeof(IFooterBarManager))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class FooterBarViewModel : IFooterBarManager
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is display footer bar.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is display footer bar; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisplayFooterBar { get; set; } = true;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; } = "Ready";

        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetMessage(string message)
        {
            this.Message = message;
        }
    }
}
