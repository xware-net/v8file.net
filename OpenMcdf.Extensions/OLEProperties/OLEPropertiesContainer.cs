﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenMcdf.Extensions.OLEProperties.Interfaces;

namespace OpenMcdf.Extensions.OLEProperties
{
    public class OLEPropertiesContainer
    {

        public Dictionary<uint, string> PropertyNames = null;

        public OLEPropertiesContainer UserDefinedProperties { get; private set; }

        public bool HasUserDefinedProperties { get; private set; }

        public ContainerType ContainerType { get; internal set; }

        public PropertyContext Context { get; private set; }

        private readonly List<OLEProperty> properties = new List<OLEProperty>();
        public PropertySetStream cfStream;

        public class DocumentSummaryInfoProperties
        {
            public string Category { get; set; }
            public string Manager { get; set; }
            public string Company { get; set; }
            public byte[] BentleyProjectProperties { get; set; }
            public byte[] BentleyWorkSetProperties { get; set; }
        }

        public class SummaryInfoProperties
        {
            public string CodePage { get; set; }
            public string Title { get; set; }
            public string Subject { get; set; }
            public string Author { get; set; }
            public string Keywords { get; set; }
            public string Comments { get; set; }
            public string Template { get; set; }
            public string LastSavedBy { get; set; }
            public string RevisionNumber { get; set; }
            public string TotalEditingTime { get; set; }
            public string LastPrintedTime { get; set; }
            public string CreatedTime { get; set; }
            public string LastSavedTime { get; set; }
            public string PageCount { get; set; }
            public int WordCount { get; set; }
            public string CharacterCount { get; set; }
            public byte[] Thumbnail { get; set; }
            public string ApplicationName { get; set; }
            public string Security { get; set; }
        }

        public static OLEPropertiesContainer CreateNewSummaryInfo(SummaryInfoProperties sumInfoProps)
        {
            return null;
        }

        public OLEPropertiesContainer(int codePage, ContainerType containerType)
        {
            Context = new PropertyContext
            {
                CodePage = codePage,
                Behavior = Behavior.CaseInsensitive
            };

            this.ContainerType = containerType;
        }

        public OLEPropertiesContainer(PropertySetStream cfStream)
        {
            PropertySetStream pStream = cfStream;
            this.cfStream = cfStream;
            switch (pStream.FMTID0.ToString("B").ToUpperInvariant())
            {
                case "{F29F85E0-4FF9-1068-AB91-08002B27B3D9}":
                    this.ContainerType = ContainerType.SummaryInfo;
                    break;
                case "{D5CDD502-2E9C-101B-9397-08002B2CF9AE}":
                    this.ContainerType = ContainerType.DocumentSummaryInfo;
                    break;
                default:
                    this.ContainerType = ContainerType.AppSpecific;
                    break;
            }

            this.PropertyNames = (Dictionary<uint, string>)pStream.PropertySet0.Properties
                .Where(p => p.PropertyType == PropertyType.DictionaryProperty).FirstOrDefault()?.Value;

            this.Context = new PropertyContext()
            {
                CodePage = pStream.PropertySet0.PropertyContext.CodePage
            };

            for (int i = 0; i < pStream.PropertySet0.Properties.Count; i++)
            {
                if (pStream.PropertySet0.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 0) continue;
                //if (pStream.PropertySet0.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 1) continue;
                //if (pStream.PropertySet0.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 0x80000000) continue;

                var p = (ITypedPropertyValue)pStream.PropertySet0.Properties[i];
                var poi = pStream.PropertySet0.PropertyIdentifierAndOffsets[i];

                var op = new OLEProperty(this)
                {
                    VTType = p.VTType,
                    PropertyIdentifier = (uint)pStream.PropertySet0.PropertyIdentifierAndOffsets[i].PropertyIdentifier,
                    Value = p.Value
                };


                properties.Add(op);
            }

            if (pStream.NumPropertySets == 2)
            {
                UserDefinedProperties = new OLEPropertiesContainer(this.Context.CodePage, ContainerType.UserDefinedProperties);
                this.HasUserDefinedProperties = true;

                UserDefinedProperties.ContainerType = ContainerType.UserDefinedProperties;

                for (int i = 0; i < pStream.PropertySet1.Properties.Count; i++)
                {
                    if (pStream.PropertySet1.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 0) continue;
                    //if (pStream.PropertySet1.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 1) continue;
                    if (pStream.PropertySet1.PropertyIdentifierAndOffsets[i].PropertyIdentifier == 0x80000000) continue;

                    var p = (ITypedPropertyValue)pStream.PropertySet1.Properties[i];
                    var poi = pStream.PropertySet1.PropertyIdentifierAndOffsets[i];

                    var op = new OLEProperty(UserDefinedProperties)
                    {
                        VTType = p.VTType,
                        PropertyIdentifier = (uint)pStream.PropertySet1.PropertyIdentifierAndOffsets[i].PropertyIdentifier,
                        Value = p.Value
                    };

                    UserDefinedProperties.properties.Add(op);
                }

                UserDefinedProperties.PropertyNames = (Dictionary<uint, string>)pStream.PropertySet1.Properties
                    .Where(p => p.PropertyType == PropertyType.DictionaryProperty).FirstOrDefault()?.Value;

            }
        }

        public IEnumerable<OLEProperty> Properties
        {
            get { return properties; }
        }

        public OLEProperty NewProperty(VTPropertyType vtPropertyType, uint propertyIdentifier, string propertyName = null)
        {
            //throw new NotImplementedException("API Unstable - Work in progress - Milestone 2.3.0.0");
            var op = new OLEProperty(this)
            {
                VTType = vtPropertyType,
                PropertyIdentifier = propertyIdentifier
            };

            return op;
        }


        public void AddProperty(OLEProperty property)
        {
            //throw new NotImplementedException("API Unstable - Work in progress - Milestone 2.3.0.0");
            properties.Add(property);
        }

        public void RemoveProperty(uint propertyIdentifier)
        {
            //throw new NotImplementedException("API Unstable - Work in progress - Milestone 2.3.0.0");
            var toRemove = properties.Where(o => o.PropertyIdentifier == propertyIdentifier).FirstOrDefault();

            if (toRemove != null)
                properties.Remove(toRemove);
        }


        //public void Save(CFStream cfStream)
        //{
        //    //throw new NotImplementedException("API Unstable - Work in progress - Milestone 2.3.0.0");
        //    //properties.Sort((a, b) => a.PropertyIdentifier.CompareTo(b.PropertyIdentifier));

        //    Stream s = new StreamDecorator(cfStream);
        //    BinaryWriter bw = new BinaryWriter(s);

        //    PropertySetStream ps = new PropertySetStream
        //    {
        //        ByteOrder = 0xFFFE,
        //        Version = 0,
        //        SystemIdentifier = 0x00020006,
        //        CLSID = Guid.Empty,

        //        NumPropertySets = 1,

        //        FMTID0 = this.ContainerType == ContainerType.SummaryInfo ? new Guid("{F29F85E0-4FF9-1068-AB91-08002B27B3D9}") : new Guid("{D5CDD502-2E9C-101B-9397-08002B2CF9AE}"),
        //        Offset0 = 0,

        //        FMTID1 = Guid.Empty,
        //        Offset1 = 0,

        //        PropertySet0 = new PropertySet
        //        {
        //            NumProperties = (uint)this.Properties.Count(),
        //            PropertyIdentifierAndOffsets = new List<PropertyIdentifierAndOffset>(),
        //            Properties = new List<Interfaces.IProperty>(),
        //            PropertyContext = this.Context
        //        }
        //    };

        //    foreach (var op in this.Properties)
        //    {
        //        ITypedPropertyValue p = PropertyFactory.Instance.NewProperty(op.VTType, this.Context.CodePage);
        //        p.Value = op.Value;
        //        ps.PropertySet0.Properties.Add(p);
        //        ps.PropertySet0.PropertyIdentifierAndOffsets.Add(new PropertyIdentifierAndOffset() { PropertyIdentifier = op.PropertyIdentifier, Offset = 0 });
        //    }

        //    ps.PropertySet0.NumProperties = (uint)this.Properties.Count();

        //    if (HasUserDefinedProperties)
        //    {
        //        ps.NumPropertySets = 2;

        //        ps.PropertySet1 = new PropertySet
        //        {
        //            NumProperties = (uint)this.UserDefinedProperties.Properties.Count(),
        //            PropertyIdentifierAndOffsets = new List<PropertyIdentifierAndOffset>(),
        //            Properties = new List<Interfaces.IProperty>(),
        //            PropertyContext = UserDefinedProperties.Context
        //        };

        //        ps.FMTID1 = new Guid("{D5CDD502-2E9C-101B-9397-08002B2CF9AE}");
        //        ps.Offset1 = 0;

        //        foreach (var op in this.Properties)
        //        {
        //            ITypedPropertyValue p = PropertyFactory.Instance.NewProperty(op.VTType, ps.PropertySet1.PropertyContext.CodePage);
        //            p.Value = op.Value;
        //            ps.PropertySet1.Properties.Add(p);
        //            ps.PropertySet1.PropertyIdentifierAndOffsets.Add(new PropertyIdentifierAndOffset() { PropertyIdentifier = op.PropertyIdentifier, Offset = 0 });

        //        }
        //    }

        //    ps.Write(bw);
        //}
    }
}
