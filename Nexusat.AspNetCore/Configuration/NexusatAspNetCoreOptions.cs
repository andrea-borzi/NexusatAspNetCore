﻿using Nexusat.AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexusat.AspNetCore.Configuration
{
    /// <summary>
    /// Nexusat ASP net core options.
    /// </summary>
    public class NexusatAspNetCoreOptions
    {
        /// <summary>
        /// Gets or sets the default ok status code.
        /// This status code is set whenever using a response method without
        /// providing a custom code and the semanthic of that method can be
        /// safely assumed to be «OK»
        /// </summary>
        /// <value>The default ok status code.</value>
        public string DefaultOkStatusCode { get; internal set; } = StatusCode.DEFAULT_OK_STATUS_CODE;
        /// <summary>
        /// Gets or sets the default ko status code.
        /// This status code is set whenever using a response method without
        /// providing a custom code and the semanthic of that method can be
        /// safely assumed to be «KO»
        /// </summary>
        /// <value>The default ko status code.</value>
        public string DefaultKoStatusCode { get; internal set; } = StatusCode.DEFAULT_KO_STATUS_CODE;
        /// <summary>
        /// Gets or sets the default unset status code.
        /// This status code is set whenever using a response method without
        /// providing a custom code and the semanthic of that method cannot be
        /// safely assumed to be «OK» or «KO».
        /// We suggest, for defensive approach, to use a «KO» code for this case.
        /// </summary>
        /// <value>The default unset status code.</value>
        public string DefaultUnsetStatusCode { get; internal set; } = StatusCode.DEFAULT_UNK_STATUS_CODE;

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Nexusat.AspNetCore.Configuration.NexusatAspNetCoreOptions"/> is runtime profilation enabled.
        /// </summary>
        /// <value><c>true</c> if is runtime profilation enabled; otherwise, <c>false</c>.</value>
        public bool IsRuntimeProfilationEnabled { get; internal set; } = false;
    }
}
