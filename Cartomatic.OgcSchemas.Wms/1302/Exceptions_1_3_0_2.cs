﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

namespace Cartomatic.OgcSchemas.Wms
{
    namespace Wms_1302
    {


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
        public partial class ServiceExceptionReport
        {

            private ServiceExceptionType[] serviceExceptionField;

            private string versionField;

            public ServiceExceptionReport()
            {
                this.versionField = "1.3.0";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ServiceException")]
            public ServiceExceptionType[] ServiceException
            {
                get { return this.serviceExceptionField; }
                set { this.serviceExceptionField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string version
            {
                get { return this.versionField; }
                set { this.versionField = value; }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
        public partial class ServiceExceptionType
        {

            private string codeField;

            private string locatorField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string code
            {
                get { return this.codeField; }
                set { this.codeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string locator
            {
                get { return this.locatorField; }
                set { this.locatorField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get { return this.valueField; }
                set { this.valueField = value; }
            }
        }
    }
}