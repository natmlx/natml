/* 
*   NatML
*   Copyright © 2023 NatML Inc. All rights reserved.
*/

namespace NatML.Internal {

    using System;
    using System.Collections.Generic;
    using UnityEngine;

    internal sealed class NatMLSettings : ScriptableObject {

        #region --Types--
        [Serializable]
        public class Embed {
            public string fingerprint;
            public byte[] data;
        }
        #endregion


        #region --Client API--
        /// <summary>
        /// Project-wide access key.
        /// </summary>
        [SerializeField, HideInInspector]
        internal string accessKey = string.Empty;

        /// <summary>
        /// Embedded model data.
        /// </summary>
        [SerializeField, HideInInspector]
        internal Embed[] embeds = new Embed[0];

        /// <summary>
        /// Settings instance for this project.
        /// </summary>
        internal static NatMLSettings Instance;
        #endregion


        #region --Operations--

        private void OnEnable () => Instance = this;
        #endregion
    }
}