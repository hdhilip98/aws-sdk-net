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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDocumentVersion operation.
    /// Deletes a version of an Amazon WorkDocs document. Use the <code>DeletePriorVersions</code>
    /// parameter to delete prior versions.
    /// </summary>
    public partial class DeleteDocumentVersionRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private bool? _deletePriorVersions;
        private string _documentId;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using AWS administrator credentials
        /// to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeletePriorVersions. 
        /// <para>
        /// When set to <code>TRUE</code>, deletes the specified version and <i>all prior versions</i>
        /// of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool DeletePriorVersions
        {
            get { return this._deletePriorVersions.GetValueOrDefault(); }
            set { this._deletePriorVersions = value; }
        }

        // Check to see if DeletePriorVersions property is set
        internal bool IsSetDeletePriorVersions()
        {
            return this._deletePriorVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The ID of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}