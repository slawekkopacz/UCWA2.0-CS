﻿using Microsoft.Skype.UCWA.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Skype.UCWA.Models
{
    /// <summary>
    /// Represents a user's persistent, personal group version two. 
    /// An application can subscribe to updates from members of this group. Updates include presence, location, or note changes for a specific contact. An application must call startOrRefreshSubscriptionToContactsAndGroups before it can receive events when a group is created, modified, or removed.
    /// </summary>
    public class Group2 : Group
    {
        public async Task Update()
        {
            await HttpService.Put(Self, this, "2");
        }

        public async Task Delete()
        {
            await HttpService.Delete(Self, "2");
        }
    }    
}
