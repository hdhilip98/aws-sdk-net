/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A summary of the latest analytics data for a specific control domain.
    /// 
    ///  
    /// <para>
    /// Control domain insights are grouped by control domain, and ranked by the highest total
    /// count of non-compliant evidence.
    /// </para>
    /// </summary>
    public partial class ControlDomainInsights
    {
        private int? _controlsCountByNoncompliantEvidence;
        private EvidenceInsights _evidenceInsights;
        private string _id;
        private DateTime? _lastUpdated;
        private string _name;
        private int? _totalControlsCount;

        /// <summary>
        /// Gets and sets the property ControlsCountByNoncompliantEvidence. 
        /// <para>
        /// The number of controls in the control domain that collected non-compliant evidence
        /// on the <code>lastUpdated</code> date. 
        /// </para>
        /// </summary>
        public int ControlsCountByNoncompliantEvidence
        {
            get { return this._controlsCountByNoncompliantEvidence.GetValueOrDefault(); }
            set { this._controlsCountByNoncompliantEvidence = value; }
        }

        // Check to see if ControlsCountByNoncompliantEvidence property is set
        internal bool IsSetControlsCountByNoncompliantEvidence()
        {
            return this._controlsCountByNoncompliantEvidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceInsights. 
        /// <para>
        /// A breakdown of the compliance check status for the evidence that’s associated with
        /// the control domain. 
        /// </para>
        /// </summary>
        public EvidenceInsights EvidenceInsights
        {
            get { return this._evidenceInsights; }
            set { this._evidenceInsights = value; }
        }

        // Check to see if EvidenceInsights property is set
        internal bool IsSetEvidenceInsights()
        {
            return this._evidenceInsights != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the control domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time when the control domain insights were last updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the control domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TotalControlsCount. 
        /// <para>
        /// The total number of controls in the control domain. 
        /// </para>
        /// </summary>
        public int TotalControlsCount
        {
            get { return this._totalControlsCount.GetValueOrDefault(); }
            set { this._totalControlsCount = value; }
        }

        // Check to see if TotalControlsCount property is set
        internal bool IsSetTotalControlsCount()
        {
            return this._totalControlsCount.HasValue; 
        }

    }
}