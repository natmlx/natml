/* 
*   NatML
*   Copyright © 2023 NatML Inc. All rights reserved.
*/

#nullable enable
#pragma warning disable 8618

namespace NatML.API.Types {

    /// <summary>
    /// Predictor endpoint session.
    /// </summary>
    public sealed class PredictionSession {

        /// <summary>
        /// Session ID.
        /// </summary>
        public string id;

        /// <summary>
        /// Date created.
        /// </summary>
        public string created;

        /// <summary>
        /// Prediction results.
        /// </summary>
        public Feature[]? results;

        /// <summary>
        /// Prediction latency in milliseconds.
        /// </summary>
        public float? latency;

        /// <summary>
        /// Prediction error.
        /// This is `null` if the prediction completed successfully.
        /// </summary>
        public string? error;

        /// <summary>
        /// Prediction logs.
        /// </summary>
        public string? logs;
    }
}