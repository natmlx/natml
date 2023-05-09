/* 
*   NatML
*   Copyright © 2023 NatML Inc. All rights reserved.
*/

namespace NatML.API.Types {

    using System;

    /// <summary>
    /// Feature normalization.
    /// </summary>
    [Serializable]
    public sealed class Normalization {
        
        /// <summary>
        /// Mean.
        /// </summary>
        public float[] mean;

        /// <summary>
        /// Standard deviation.
        /// </summary>
        public float[] std;
    }
}