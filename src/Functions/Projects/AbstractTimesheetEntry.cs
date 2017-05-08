﻿/*
 * Copyright 2017 Intacct Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * or in the "LICENSE" file accompanying this file. This file is distributed on 
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
 * express or implied. See the License for the specific language governing 
 * permissions and limitations under the License.
 */

using Intacct.Sdk.Xml;
using System;
using System.Collections.Generic;

namespace Intacct.Sdk.Functions.Projects
{

    abstract public class AbstractTimesheetEntry
    {
        
        public DateTime EntryDate;
        
        public decimal? Quantity;
        
        public string Description;
        
        public string Notes;
        
        public int? TaskRecordNo;
        
        public string TimeTypeName;
        
        public bool? Billable;
        
        public decimal? OverrideBillingRate;
        
        public decimal? OverrideLaborCostRate;
        
        public string DepartmentId;
        
        public string LocationId;
        
        public string ProjectId;
        
        public string CustomerId;
        
        public string VendorId;
        
        public string ItemId;
        
        public string ClassId;
        
        public string ContractId;
        
        public string WarehouseId;

        public Dictionary<string, dynamic> CustomFields = new Dictionary<string, dynamic>();

        public AbstractTimesheetEntry()
        {
        }

        abstract public void WriteXml(ref IaXmlWriter xml);
    }

}