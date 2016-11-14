﻿using Microsoft.Skype.UCWA.Services;
using System.Threading.Tasks;

namespace Microsoft.Skype.UCWA.Models
{
    /// <summary>
    /// Represents the entry point for registering this application with the server. 
    /// </summary>
    public class Applications2 : Applications
    {          
        public async Task<Application> Get()
        {
            return await HttpService.Get<Application>(Self);
        }    
    }
}
