﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSAutoPoolSpecification
    {
        
        internal Microsoft.Azure.Batch.AutoPoolSpecification omObject;
        
        private PSPoolSpecification poolSpecification;
        
        public PSAutoPoolSpecification()
        {
            this.omObject = new Microsoft.Azure.Batch.AutoPoolSpecification();
        }
        
        internal PSAutoPoolSpecification(Microsoft.Azure.Batch.AutoPoolSpecification omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string AutoPoolIdPrefix
        {
            get
            {
                return this.omObject.AutoPoolIdPrefix;
            }
            set
            {
                this.omObject.AutoPoolIdPrefix = value;
            }
        }
        
        public System.Boolean? KeepAlive
        {
            get
            {
                return this.omObject.KeepAlive;
            }
            set
            {
                this.omObject.KeepAlive = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.PoolLifetimeOption PoolLifetimeOption
        {
            get
            {
                return this.omObject.PoolLifetimeOption;
            }
            set
            {
                this.omObject.PoolLifetimeOption = value;
            }
        }
        
        public PSPoolSpecification PoolSpecification
        {
            get
            {
                if (((this.poolSpecification == null) 
                            && (this.omObject.PoolSpecification != null)))
                {
                    this.poolSpecification = new PSPoolSpecification(this.omObject.PoolSpecification);
                }
                return this.poolSpecification;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.PoolSpecification = null;
                }
                else
                {
                    this.omObject.PoolSpecification = value.omObject;
                }
                this.poolSpecification = value;
            }
        }
    }
}
