// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.41537 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>XMLDemo</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace XMLDemo
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    public partial class students
    {

        private List<studentsStudent> studentField;

        public students()
        {
            this.studentField = new List<studentsStudent>();
        }

        public List<studentsStudent> student
        {
            get
            {
                return this.studentField;
            }
            set
            {
                this.studentField = value;
            }
        }
    }

    public partial class studentsStudent
    {

        private byte idField;

        private string firstnameField;

        private string lastnameField;

        private string cityField;

        private string genderField;

        private ushort postalcodeField;

        private string mobilenoField;

        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        public string firstname
        {
            get
            {
                return this.firstnameField;
            }
            set
            {
                this.firstnameField = value;
            }
        }

        public string lastname
        {
            get
            {
                return this.lastnameField;
            }
            set
            {
                this.lastnameField = value;
            }
        }

        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        public string gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        public ushort postalcode
        {
            get
            {
                return this.postalcodeField;
            }
            set
            {
                this.postalcodeField = value;
            }
        }

        public string mobileno
        {
            get
            {
                return this.mobilenoField;
            }
            set
            {
                this.mobilenoField = value;
            }
        }
    }
}
