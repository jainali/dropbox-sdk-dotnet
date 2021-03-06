// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Removed members from directory restrictions list.</para>
    /// </summary>
    public class DirectoryRestrictionsRemoveMembersDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DirectoryRestrictionsRemoveMembersDetails> Encoder = new DirectoryRestrictionsRemoveMembersDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DirectoryRestrictionsRemoveMembersDetails> Decoder = new DirectoryRestrictionsRemoveMembersDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DirectoryRestrictionsRemoveMembersDetails" /> class.</para>
        /// </summary>
        public DirectoryRestrictionsRemoveMembersDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DirectoryRestrictionsRemoveMembersDetails" />.</para>
        /// </summary>
        private class DirectoryRestrictionsRemoveMembersDetailsEncoder : enc.StructEncoder<DirectoryRestrictionsRemoveMembersDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DirectoryRestrictionsRemoveMembersDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DirectoryRestrictionsRemoveMembersDetails" />.</para>
        /// </summary>
        private class DirectoryRestrictionsRemoveMembersDetailsDecoder : enc.StructDecoder<DirectoryRestrictionsRemoveMembersDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DirectoryRestrictionsRemoveMembersDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DirectoryRestrictionsRemoveMembersDetails Create()
            {
                return new DirectoryRestrictionsRemoveMembersDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DirectoryRestrictionsRemoveMembersDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
