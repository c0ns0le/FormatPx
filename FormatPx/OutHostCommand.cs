﻿using System;
using System.Management.Automation;

namespace FormatPx
{
    [Cmdlet(
        VerbsData.Out,
        "Host",
        HelpUri = "http://go.microsoft.com/fwlink/p/?linkid=289601"
    )]
    [OutputType(typeof(void))]
    public class OutHostCommand : Microsoft.PowerShell.Commands.OutHostCommand
    {
        OutProxyCmdletHelper outProxyHelper = null;

        protected override void BeginProcessing()
        {
            // Start processing the proxy command
            outProxyHelper = new OutProxyCmdletHelper(this);
            outProxyHelper.Begin();
        }

        protected override void ProcessRecord()
        {
            // Process any input that was received
            outProxyHelper.ProcessInputObject();
        }

        protected override void EndProcessing()
        {
            // End the processing of the proxy command
            outProxyHelper.End();
        }
    }
}