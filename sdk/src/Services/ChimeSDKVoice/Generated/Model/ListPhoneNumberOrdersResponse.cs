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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the ListPhoneNumberOrders operation.
    /// </summary>
    public partial class ListPhoneNumberOrdersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PhoneNumberOrder> _phoneNumberOrders = new List<PhoneNumberOrder>();

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberOrders.
        /// </summary>
        public List<PhoneNumberOrder> PhoneNumberOrders
        {
            get { return this._phoneNumberOrders; }
            set { this._phoneNumberOrders = value; }
        }

        // Check to see if PhoneNumberOrders property is set
        internal bool IsSetPhoneNumberOrders()
        {
            return this._phoneNumberOrders != null && this._phoneNumberOrders.Count > 0; 
        }

    }
}