﻿/*
 * Copyright 2014 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

// TODO:
// [ ] Contracts
// [ ] Documentation
// [ ] Properties & Methods

namespace Splunk.Sdk
{
    using System.Threading.Tasks;

    public class Configuration : Entity<Configuration>
    {
        #region Constructors

        internal Configuration(Context context, Namespace @namespace, string name)
            : base(context, @namespace, ResourceName.Properties, name)
        { }

        public Configuration()
        { }

        #endregion

        #region Methods

        public StanzaCollection GetStanzas()
        {
            return GetStanzasAsync().Result;
        }

        public async Task<StanzaCollection> GetStanzasAsync()
        {
            var collection = new StanzaCollection(this.Context, this.Namespace, this.ResourceName);
            await collection.UpdateAsync();
            return collection;
        }
        
        #endregion
    }
}
