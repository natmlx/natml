/* 
*   NatML
*   Copyright (c) 2021 Yusuf Olokoba.
*/

namespace NatSuite.ML.Hub.Requests {

    using System;

    [Serializable]
    public sealed class CreateSessionRequest : MLHubRequest {

        public Variables variables;

        public CreateSessionRequest (Input input) : base(@"
            mutation ($input: CreateSessionInput!) {
                createSession (input: $input) {
                    id
                    predictor {
                        tag
                        type
                        labels
                        normalization { mean std }
                        aspectMode
                        audioFormat { sampleRate channelCount }
                    }
                    graph
                    flags
                }
            }
        ") => this.variables = new Variables { input = input };

        [Serializable]
        public sealed class Variables {
            public Input input;
        }

        [Serializable]
        public sealed class Input {
            public string tag;
            public Device device;
        }

        [Serializable]
        public sealed class Device {
            public string os;
            public string model;
            public string gfx;
            public string framework;
        }
    }
}