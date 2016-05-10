﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lithnet.GoogleApps.MA
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Xml;
    using ManagedObjects;
    using Microsoft.MetadirectoryServices;

    public static class SchemaBuilder
    {
        public static MASchemaType GetUserSchema()
        {
            MASchemaType type = new MASchemaType
            {
                Attributes = new List<IMASchemaAttribute>(),
                Name = "user"
            };

            MASchemaAttribute orgUnitPath = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "orgUnitPath",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                AttributeName = "orgUnitPath",
                PropertyName = "OrgUnitPath",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(orgUnitPath);

            MASchemaAttribute includeInGal = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "includeInGlobalAddressList",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                AttributeName = "includeInGlobalAddressList",
                PropertyName = "IncludeInGlobalAddressList",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(includeInGal);

            MASchemaAttribute suspended = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "suspended",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                AttributeName = "suspended",
                PropertyName = "Suspended",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(suspended);

            MASchemaAttribute changePasswordAtNextLogin = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "changePasswordAtNextLogin",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                AttributeName = "changePasswordAtNextLogin",
                PropertyName = "ChangePasswordAtNextLogin",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(changePasswordAtNextLogin);

            MASchemaAttribute ipWhitelisted = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "ipWhitelisted",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "ipWhitelisted",
                PropertyName = "IpWhitelisted",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(ipWhitelisted);

            MASchemaAttribute id = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "id",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "id",
                PropertyName = "Id",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(id);

            MASchemaAttribute primaryEmail = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "primaryEmail",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "primaryEmail",
                PropertyName = "PrimaryEmail",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(primaryEmail);

            MASchemaAttribute isAdmin = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "isAdmin",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                AttributeName = "isAdmin",
                PropertyName = "IsAdmin",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(isAdmin);

            MASchemaAttribute isDelegatedAdmin = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "isDelegatedAdmin",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "isDelegatedAdmin",
                PropertyName = "IsDelegatedAdmin",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(isDelegatedAdmin);

            MASchemaAttribute lastLoginTime = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "lastLoginTime",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "lastLoginTime",
                PropertyName = "LastLoginTime",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(lastLoginTime);

            MASchemaAttribute creationTime = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "creationTime",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "creationTime",
                PropertyName = "CreationTime",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(creationTime);

            MASchemaAttribute deletionTime = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "deletionTime",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "deletionTime",
                PropertyName = "DeletionTime",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(deletionTime);

            MASchemaAttribute agreedToTerms = new MASchemaAttribute
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "agreedToTerms",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "agreedToTerms",
                PropertyName = "AgreedToTerms",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(agreedToTerms);

            MASchemaAttribute suspensionReason = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "suspensionReason",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "suspensionReason",
                PropertyName = "SuspensionReason",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(suspensionReason);

            MASchemaAttribute isMailboxSetup = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "isMailboxSetup",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "isMailboxSetup",
                PropertyName = "IsMailboxSetup",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(isMailboxSetup);

            MASchemaAttribute thumbnailPhotoUrl = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "thumbnailPhotoUrl",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "thumbnailPhotoUrl",
                PropertyName = "ThumbnailPhotoUrl",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(thumbnailPhotoUrl);

            MASchemaAttribute thumbnailPhotoEtag = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "thumbnailPhotoEtag",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "thumbnailPhotoEtag",
                PropertyName = "ThumbnailPhotoEtag",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(thumbnailPhotoEtag);

            MASchemaAttribute customerId = new MASchemaAttribute
            {
                AttributeType = AttributeType.String,
                FieldName = "customerId",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportOnly,
                AttributeName = "customerId",
                PropertyName = "CustomerId",
                Api = "user",
                CanPatch = true,
                IsArrayAttribute = false
            };

            type.Attributes.Add(customerId);

            SchemaBuilder.AddNames(type);
            SchemaBuilder.AddNotes(type);
            SchemaBuilder.AddWebSites(type);
            SchemaBuilder.AddAliases(type);
            SchemaBuilder.AddPhonesAttributes(type);
            SchemaBuilder.AddOrganizationsAttributes(type);
            SchemaBuilder.AddAddresses(type);
            SchemaBuilder.AddRelations(type);
            SchemaBuilder.AddExternalIds(type);
            SchemaBuilder.AddIms(type);

            return type;
        }

        private static void AddNames(MASchemaType type)
        {
            MASchemaArrayField givenName = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "givenName",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "GivenName",
                AttributeNamePart = "givenName"
            };

            MASchemaArrayField familyName = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "familyName",
                IsMultivalued = false,
                PropertyName = "FamilyName",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "familyName"
            };

            MASchemaNestedType schemaItem = new MASchemaNestedType
            {
                Api = "user",
                AttributeName = "name",
                Fields = new List<MASchemaArrayField>() { givenName, familyName },
                FieldName = "name",
                PropertyName = "Name",
                CanPatch = false
            };

            type.Attributes.Add(schemaItem);
        }

        private static void AddNotes(MASchemaType type)
        {
            MASchemaArrayField notesValue = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "value",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Value",
                AttributeNamePart = "value"
            };

            MASchemaArrayField notesContentType = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "contentType",
                IsMultivalued = false,
                PropertyName = "ContentType",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "contentType"
            };

            MASchemaNestedType notesType = new MASchemaNestedType
            {
                Api = "user",
                AttributeName = "notes",
                Fields = new List<MASchemaArrayField>() { notesContentType, notesValue },
                FieldName = "notes",
                PropertyName = "Notes",
                CanPatch = false
            };

            type.Attributes.Add(notesType);
        }

        private static void AddWebSites(MASchemaType type)
        {
            MASchemaArrayField webSiteValue = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "value",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Value",
                AttributeNamePart = "value"
            };

            MASchemaArrayField webSitePrimary = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "primary",
                IsMultivalued = false,
                PropertyName = "Primary",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "primary"
            };

            MASchemaCustomTypeArray webSiteType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "websites",
                Fields = new List<MASchemaArrayField>() { webSitePrimary, webSiteValue },
                FieldName = "websites",
                PropertyName = "Websites",
                Type = typeof(Website),
                KnownTypes = new List<string>() { "work", "home", "other" },
                CanPatch = false
            };

            type.Attributes.Add(webSiteType);
        }

        private static void AddAliases(MASchemaType type)
        {
            MASchemaSimpleList aliasesList = new MASchemaSimpleList
            {
                Api = "useraliases",
                AttributeName = "aliases",
                FieldName = "aliases",
                PropertyName = "Aliases",
                CanPatch = true,
                IsReadOnly = false
            };

            type.Attributes.Add(aliasesList);

            MASchemaSimpleList nonEditableAliasesList = new MASchemaSimpleList
            {
                Api = "user",
                AttributeName = "nonEditableAliases",
                FieldName = "nonEditableAliases",
                PropertyName = "NonEditableAliases",
                CanPatch = false,
                IsReadOnly = true
            };

            type.Attributes.Add(nonEditableAliasesList);
        }

        private static void AddPhonesAttributes(MASchemaType type)
        {
            MASchemaArrayField phonesValue = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "value",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Value",
                AttributeNamePart = "value"
            };

            MASchemaArrayField phonesPrimary = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "primary",
                IsMultivalued = false,
                PropertyName = "Primary",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "primary"
            };

            MASchemaCustomTypeArray phonesType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "phones",
                Fields = new List<MASchemaArrayField>() { phonesPrimary, phonesValue },
                FieldName = "phones",
                PropertyName = "Phones",
                Type = typeof(Phone),
                KnownTypes = new List<string>() { "work", "home", "other" },
                CanPatch = false
            };

            type.Attributes.Add(phonesType);
        }

        private static void AddOrganizationsAttributes(MASchemaType type)
        {
            MASchemaArrayField name = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "name",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Name",
                AttributeNamePart = "name"
            };

            MASchemaArrayField title = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "title",
                IsMultivalued = false,
                PropertyName = "Title",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "title"
            };

            MASchemaArrayField primary = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "primary",
                IsMultivalued = false,
                PropertyName = "Primary",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "primary"
            };

            MASchemaArrayField department = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "department",
                IsMultivalued = false,
                PropertyName = "Department",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "department"
            };

            MASchemaArrayField symbol = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "symbol",
                IsMultivalued = false,
                PropertyName = "Symbol",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "symbol"
            };


            MASchemaArrayField location = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "location",
                IsMultivalued = false,
                PropertyName = "Location",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "location"
            };

            MASchemaArrayField description = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "description",
                IsMultivalued = false,
                PropertyName = "Description",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "description"
            };

            MASchemaArrayField domain = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "domain",
                IsMultivalued = false,
                PropertyName = "Domain",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "domain"
            };

            MASchemaArrayField costCenter = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "costCenter",
                IsMultivalued = false,
                PropertyName = "CostCenter",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "costCenter"
            };

            MASchemaCustomTypeArray customType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "organizations",
                Fields = new List<MASchemaArrayField>() { name, title, primary, department, symbol, location, description, domain, costCenter },
                FieldName = "organizations",
                PropertyName = "Organizations",
                Type = typeof(Organization),
                KnownTypes = new List<string>() { "work" },
                CanPatch = false
            };

            type.Attributes.Add(customType);
        }

        private static void AddAddresses(MASchemaType type)
        {
            MASchemaArrayField sourceIsStructured = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "sourceIsStructured",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "SourceIsStructured",
                AttributeNamePart = "sourceIsStructured"
            };

            MASchemaArrayField formatted = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "formatted",
                IsMultivalued = false,
                PropertyName = "Formatted",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "formatted"
            };

            MASchemaArrayField primary = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "primary",
                IsMultivalued = false,
                PropertyName = "Primary",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "primary"
            };

            MASchemaArrayField poBox = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "poBox",
                IsMultivalued = false,
                PropertyName = "POBox",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "poBox"
            };

            MASchemaArrayField extendedAddress = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "extendedAddress",
                IsMultivalued = false,
                PropertyName = "ExtendedAddress",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "extendedAddress"
            };


            MASchemaArrayField streetAddress = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "streetAddress",
                IsMultivalued = false,
                PropertyName = "StreetAddress",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "streetAddress"
            };

            MASchemaArrayField locality = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "locality",
                IsMultivalued = false,
                PropertyName = "Locality",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "locality"
            };

            MASchemaArrayField region = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "region",
                IsMultivalued = false,
                PropertyName = "Region",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "region"
            };

            MASchemaArrayField postalCode = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "postalCode",
                IsMultivalued = false,
                PropertyName = "PostalCode",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "postalCode"
            };

            MASchemaArrayField country = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "country",
                IsMultivalued = false,
                PropertyName = "Country",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "country"
            };

            MASchemaArrayField countryCode = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "countryCode",
                IsMultivalued = false,
                PropertyName = "CountryCode",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "countryCode"
            };

            MASchemaCustomTypeArray customType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "addresses",
                Fields = new List<MASchemaArrayField>() { sourceIsStructured, formatted, poBox, extendedAddress, primary, streetAddress, locality, region, postalCode, country, countryCode },
                FieldName = "addresses",
                PropertyName = "Addresses",
                Type = typeof(Address),
                KnownTypes = new List<string>() { "work" },
                CanPatch = false
            };

            type.Attributes.Add(customType);
        }

        private static void AddRelations(MASchemaType type)
        {
            MASchemaArrayField value = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "value",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Value",
                AttributeNamePart = "value"
            };

            MASchemaCustomTypeArray customType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "relations",
                Fields = new List<MASchemaArrayField>() { value },
                FieldName = "relations",
                PropertyName = "relations",
                Type = typeof(Relation),
                KnownTypes = new List<string>() { "work", "home", "other" },
                CanPatch = false
            };

            type.Attributes.Add(customType);
        }

        private static void AddExternalIds(MASchemaType type)
        {
            MASchemaArrayField value = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "value",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Value",
                AttributeNamePart = "value"
            };

            MASchemaCustomTypeArray customType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "externalIds",
                Fields = new List<MASchemaArrayField>() { value },
                FieldName = "externalIds",
                PropertyName = "externalIds",
                Type = typeof(Relation),
                KnownTypes = new List<string>() { "work" },
                CanPatch = false
            };

            type.Attributes.Add(customType);
        }

        private static void AddIms(MASchemaType type)
        {
            MASchemaArrayField im = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "im",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "IMAddress",
                AttributeNamePart = "im"
            };

            MASchemaArrayField protocol = new MASchemaArrayField
            {
                AttributeType = AttributeType.String,
                FieldName = "protocol",
                IsMultivalued = false,
                Operation = AttributeOperation.ImportExport,
                PropertyName = "Protocol",
                AttributeNamePart = "protocol"
            };

            MASchemaArrayField primary = new MASchemaArrayField
            {
                AttributeType = AttributeType.Boolean,
                FieldName = "primary",
                IsMultivalued = false,
                PropertyName = "Primary",
                Operation = AttributeOperation.ImportExport,
                AttributeNamePart = "primary"
            };

            MASchemaCustomTypeArray customType = new MASchemaCustomTypeArray
            {
                Api = "user",
                AttributeName = "ims",
                Fields = new List<MASchemaArrayField>() { im, protocol, primary },
                FieldName = "ims",
                PropertyName = "ims",
                Type = typeof(IM),
                KnownTypes = new List<string>() { "work" },
                CanPatch = false
            };

            type.Attributes.Add(customType);
        }

        public static void Save<T>(string filename, T obj)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlWriterSettings writerSettings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  ",
                    NewLineChars = Environment.NewLine,
                    NamespaceHandling = NamespaceHandling.OmitDuplicates
                };

                using (XmlWriter writer = XmlWriter.Create(stream, writerSettings))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                    serializer.WriteObject(writer, obj);

                    writer.Flush();
                    writer.Close();
                }
            }
        }
    }
}