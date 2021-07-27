// ----------------------------------------------------------------------------------
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

namespace Microsoft.Azure.Commands.NetAppFiles.Models
{

    public class PSNetAppFilesVolumeRestoreStatus
    {
        /// <summary>
        /// Gets or sets Healthy
        /// </summary>
        /// <remarks>
        /// Restore health status
        /// </remarks>
        public bool? Healthy { get; set; }

        /// <summary>
        /// Gets or sets RelationshipStatus
        /// </summary>
        /// <remarks>
        /// Status of the restore SnapMirror relationship
        /// </remarks>
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// Gets or sets MirrorState
        /// </summary>
        /// <remarks>
        /// The status of the restore ("Uninitialized", "Mirrored", "Broken")
        /// </remarks>
        public string MirrorState { get; set; }

        /// <summary>
        /// Gets or sets UnhealthyReason
        /// </summary>
        /// <remarks>
        /// Reason for the unhealthy restore relationship
        /// </remarks>
        public string UnhealthyReason { get; set; }

        /// <summary>
        /// Gets or sets ErrorMessage
        /// </summary>
        /// <remarks>
        /// Displays error message if the restore is in an error state
        /// </remarks>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets TotalTransferBytes
        /// </summary>
        /// <remarks>
        /// Displays the total bytes transferred
        /// </remarks>
        public long? TotalTransferBytes { get; set; }
    }
}