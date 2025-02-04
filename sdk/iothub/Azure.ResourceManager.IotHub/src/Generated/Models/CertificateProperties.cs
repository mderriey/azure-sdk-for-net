// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The description of an X509 CA Certificate. </summary>
    public partial class CertificateProperties
    {
        /// <summary> Initializes a new instance of CertificateProperties. </summary>
        public CertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of CertificateProperties. </summary>
        /// <param name="subject"> The certificate&apos;s subject name. </param>
        /// <param name="expiry"> The certificate&apos;s expiration date and time. </param>
        /// <param name="thumbprint"> The certificate&apos;s thumbprint. </param>
        /// <param name="isVerified"> Determines whether certificate has been verified. </param>
        /// <param name="created"> The certificate&apos;s create date and time. </param>
        /// <param name="updated"> The certificate&apos;s last update date and time. </param>
        /// <param name="certificate"> The certificate content. </param>
        internal CertificateProperties(string subject, DateTimeOffset? expiry, string thumbprint, bool? isVerified, DateTimeOffset? created, DateTimeOffset? updated, string certificate)
        {
            Subject = subject;
            Expiry = expiry;
            Thumbprint = thumbprint;
            IsVerified = isVerified;
            Created = created;
            Updated = updated;
            Certificate = certificate;
        }

        /// <summary> The certificate&apos;s subject name. </summary>
        public string Subject { get; }
        /// <summary> The certificate&apos;s expiration date and time. </summary>
        public DateTimeOffset? Expiry { get; }
        /// <summary> The certificate&apos;s thumbprint. </summary>
        public string Thumbprint { get; }
        /// <summary> Determines whether certificate has been verified. </summary>
        public bool? IsVerified { get; set; }
        /// <summary> The certificate&apos;s create date and time. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> The certificate&apos;s last update date and time. </summary>
        public DateTimeOffset? Updated { get; }
        /// <summary> The certificate content. </summary>
        public string Certificate { get; set; }
    }
}
