/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.pvtz.Transform;
using Aliyun.Acs.pvtz.Transform.V20180101;

namespace Aliyun.Acs.pvtz.Model.V20180101
{
    public class CheckZoneNameRequest : RpcAcsRequest<CheckZoneNameResponse>
    {
        public CheckZoneNameRequest()
            : base("pvtz", "2018-01-01", "CheckZoneName", "pvtz", "openAPI")
        {
        }

		private string userClientIp;

		private string lang;

		private string zoneName;

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string ZoneName
		{
			get
			{
				return zoneName;
			}
			set	
			{
				zoneName = value;
				DictionaryUtil.Add(QueryParameters, "ZoneName", value);
			}
		}

        public override CheckZoneNameResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckZoneNameResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
