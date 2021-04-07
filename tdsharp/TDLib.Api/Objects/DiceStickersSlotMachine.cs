using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class DiceStickers : Object
        {
            /// <summary>
            /// Animated stickers to be combined into a slot machine
            /// </summary>
            public class DiceStickersSlotMachine : DiceStickers
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "diceStickersSlotMachine";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The animated sticker with the slot machine background. The background animation must start playing after all reel animations finish
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("background")]
                public Sticker Background { get; set; }

                /// <summary>
                /// The animated sticker with the lever animation. The lever animation must play once in the initial dice state
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("lever")]
                public Sticker Lever { get; set; }

                /// <summary>
                /// The animated sticker with the left reel
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("left_reel")]
                public Sticker LeftReel { get; set; }

                /// <summary>
                /// The animated sticker with the center reel
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("center_reel")]
                public Sticker CenterReel { get; set; }

                /// <summary>
                /// The animated sticker with the right reel
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("right_reel")]
                public Sticker RightReel { get; set; }
            }
        }
    }
}