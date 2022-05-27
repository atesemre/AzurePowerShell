﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.StorageSync.Common.Converters
{
    using Microsoft.Azure.Commands.StorageSync.Models;
    using System;
    using StorageSyncModels = Microsoft.Azure.Management.StorageSync.Models;

    /// <summary>
    /// Class CloudTieringVolumeFreeSpacePolicyStatusConverter.
    /// Implements the <see cref="Converters.ConverterBase{PSCloudTieringVolumeFreeSpacePolicyStatus, CloudTieringVolumeFreeSpacePolicyStatus}" />
    /// </summary>
    /// <seealso cref="Converters.ConverterBase{PSCloudTieringVolumeFreeSpacePolicyStatus, CloudTieringVolumeFreeSpacePolicyStatus}" />
    public class CloudTieringVolumeFreeSpacePolicyStatusConverter : ConverterBase<PSCloudTieringVolumeFreeSpacePolicyStatus, StorageSyncModels.CloudTieringVolumeFreeSpacePolicyStatus>
    {
        /// <summary>
        /// Transforms the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>StorageSyncModels.CloudTieringVolumeFreeSpacePolicyStatus.</returns>
        protected override StorageSyncModels.CloudTieringVolumeFreeSpacePolicyStatus Transform(PSCloudTieringVolumeFreeSpacePolicyStatus source)
        {
            // Cloud tiering status properties are readonly from the RP
            throw new NotSupportedException();
        }

        /// <summary>
        /// Transforms the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>PSCloudTieringVolumeFreeSpacePolicyStatus.</returns>
        protected override PSCloudTieringVolumeFreeSpacePolicyStatus Transform(StorageSyncModels.CloudTieringVolumeFreeSpacePolicyStatus source)
        {
            return new PSCloudTieringVolumeFreeSpacePolicyStatus()
            {
                LastUpdatedTimestamp = source.LastUpdatedTimestamp,
                CurrentVolumeFreeSpacePercent = source.CurrentVolumeFreeSpacePercent,
                EffectiveVolumeFreeSpacePolicy = source.EffectiveVolumeFreeSpacePolicy
            };
        }
    }
}
