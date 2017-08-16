// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateProductType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateProductType
    {
        [EnumMember(Value = "StandardDomainValidatedSsl")]
        StandardDomainValidatedSsl,
        [EnumMember(Value = "StandardDomainValidatedWildCardSsl")]
        StandardDomainValidatedWildCardSsl
    }
    internal static class CertificateProductTypeEnumExtension
    {
        internal static string ToSerializedValue(this CertificateProductType? value)  =>
            value == null ? null : ((CertificateProductType)value).ToSerializedValue();

        internal static string ToSerializedValue(this CertificateProductType value)
        {
            switch( value )
            {
                case CertificateProductType.StandardDomainValidatedSsl:
                    return "StandardDomainValidatedSsl";
                case CertificateProductType.StandardDomainValidatedWildCardSsl:
                    return "StandardDomainValidatedWildCardSsl";
            }
            return null;
        }

        internal static CertificateProductType? ParseCertificateProductType(this string value)
        {
            switch( value )
            {
                case "StandardDomainValidatedSsl":
                    return CertificateProductType.StandardDomainValidatedSsl;
                case "StandardDomainValidatedWildCardSsl":
                    return CertificateProductType.StandardDomainValidatedWildCardSsl;
            }
            return null;
        }
    }
}