using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class BackgroundFill : Object
        {
            /// <summary>
            /// Describes a fill of a background
            /// </summary>
            public class BackgroundFillSolid : BackgroundFill
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "backgroundFillSolid";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A color of the background in the RGB24 format
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("color")]
                public int Color { get; set; }
            }
        }
    }
}