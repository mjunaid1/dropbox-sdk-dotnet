// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The link audience object</para>
    /// </summary>
    public class LinkAudience
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LinkAudience> Encoder = new LinkAudienceEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LinkAudience> Decoder = new LinkAudienceDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LinkAudience" /> class.</para>
        /// </summary>
        public LinkAudience()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Public</para>
        /// </summary>
        public bool IsPublic
        {
            get
            {
                return this is Public;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Public, or <c>null</c>.</para>
        /// </summary>
        public Public AsPublic
        {
            get
            {
                return this as Public;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Team</para>
        /// </summary>
        public bool IsTeam
        {
            get
            {
                return this is Team;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Team, or <c>null</c>.</para>
        /// </summary>
        public Team AsTeam
        {
            get
            {
                return this as Team;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Members</para>
        /// </summary>
        public bool IsMembers
        {
            get
            {
                return this is Members;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Members, or <c>null</c>.</para>
        /// </summary>
        public Members AsMembers
        {
            get
            {
                return this as Members;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LinkAudience" />.</para>
        /// </summary>
        private class LinkAudienceEncoder : enc.StructEncoder<LinkAudience>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LinkAudience value, enc.IJsonWriter writer)
            {
                if (value is Public)
                {
                    WriteProperty(".tag", "public", writer, enc.StringEncoder.Instance);
                    Public.Encoder.EncodeFields((Public)value, writer);
                    return;
                }
                if (value is Team)
                {
                    WriteProperty(".tag", "team", writer, enc.StringEncoder.Instance);
                    Team.Encoder.EncodeFields((Team)value, writer);
                    return;
                }
                if (value is Members)
                {
                    WriteProperty(".tag", "members", writer, enc.StringEncoder.Instance);
                    Members.Encoder.EncodeFields((Members)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LinkAudience" />.</para>
        /// </summary>
        private class LinkAudienceDecoder : enc.UnionDecoder<LinkAudience>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LinkAudience" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LinkAudience Create()
            {
                return new LinkAudience();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LinkAudience Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "public":
                        return Public.Decoder.DecodeFields(reader);
                    case "team":
                        return Team.Decoder.DecodeFields(reader);
                    case "members":
                        return Members.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Link is accessible by anyone.</para>
        /// </summary>
        public sealed class Public : LinkAudience
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Public> Encoder = new PublicEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Public> Decoder = new PublicDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Public" /> class.</para>
            /// </summary>
            private Public()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Public</para>
            /// </summary>
            public static readonly Public Instance = new Public();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Public" />.</para>
            /// </summary>
            private class PublicEncoder : enc.StructEncoder<Public>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Public value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Public" />.</para>
            /// </summary>
            private class PublicDecoder : enc.StructDecoder<Public>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Public" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Public Create()
                {
                    return new Public();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Public DecodeFields(enc.IJsonReader reader)
                {
                    return Public.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Link is accessible only by team members.</para>
        /// </summary>
        public sealed class Team : LinkAudience
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Team> Encoder = new TeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Team> Decoder = new TeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            private Team()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Team</para>
            /// </summary>
            public static readonly Team Instance = new Team();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamEncoder : enc.StructEncoder<Team>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Team value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Team" />.</para>
            /// </summary>
            private class TeamDecoder : enc.StructDecoder<Team>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Team" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Team Create()
                {
                    return new Team();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Team DecodeFields(enc.IJsonReader reader)
                {
                    return Team.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Link is accessible only by members of the content.</para>
        /// </summary>
        public sealed class Members : LinkAudience
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Members> Encoder = new MembersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Members> Decoder = new MembersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Members" /> class.</para>
            /// </summary>
            private Members()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Members</para>
            /// </summary>
            public static readonly Members Instance = new Members();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Members" />.</para>
            /// </summary>
            private class MembersEncoder : enc.StructEncoder<Members>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Members value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Members" />.</para>
            /// </summary>
            private class MembersDecoder : enc.StructDecoder<Members>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Members" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Members Create()
                {
                    return new Members();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Members DecodeFields(enc.IJsonReader reader)
                {
                    return Members.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LinkAudience
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}