
#region Copyright Notice
/**
 * Copyright 2016 National Security Technologies, LLC
 * 
 * This manuscript has been authored by National Security Technologies, LLC,
 * under Contract No. DE-AC52-06NA25946 with the U.S. Department of Energy
 * 
 * DISCLAIMER
 * This document was prepared as an account of work sponsored by an agency 
 * of the United States Government. Neither the United States Government nor
 * any agency thereof, nor any of their employees, nor any of their contractors,
 * subcontractors or their employees, makes any warranty, express or implied,
 * or assumes any legal liability or responsibility for the accuracy, completeness,
 * or any third party's use or the results of such use of any information, 
 * apparatus, product, or process disclosed, or represents that its use would not
 * infringe privately owned rights. Reference herein to any specific commercial
 * product, process, or service by trade name, trademark, manufacturer, or 
 * otherwise, does not necessarily constitute or imply its endorsement, 
 * recommendation, or favoring by the United States Government or any agency 
 * thereof or its contractors or subcontractors. The views and opinions of authors
 * expressed herein do not necessarily state or reflect those of the United States
 * Government or any agency thereof.

Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
#endregion

namespace gov.nnss.rsl.xsim.xsd
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("CipherData", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class CipherDataType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CipherReference", typeof(CipherReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("CipherValue", typeof(byte[]), DataType = "base64Binary")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("CipherReference", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class CipherReferenceType
    {

        private TransformsType itemField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transforms")]
        public TransformsType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    public partial class TransformsType
    {

        private TransformType[] transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public TransformType[] Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformType
    {

        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    public partial class ReferenceType
    {

        private System.Xml.XmlElement[] anyField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SPKIDataType
    {

        private byte[][] sPKISexpField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
        public byte[][] SPKISexp
        {
            get
            {
                return this.sPKISexpField;
            }
            set
            {
                this.sPKISexpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class PGPDataType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        PGPKeyID,

        /// <remarks/>
        PGPKeyPacket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialType
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class X509DataType
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        X509CRL,

        /// <remarks/>
        X509Certificate,

        /// <remarks/>
        X509IssuerSerial,

        /// <remarks/>
        X509SKI,

        /// <remarks/>
        X509SubjectName,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RetrievalMethodType
    {

        private TransformType[] transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RSAKeyValueType
    {

        private byte[] modulusField;

        private byte[] exponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Modulus
        {
            get
            {
                return this.modulusField;
            }
            set
            {
                this.modulusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DSAKeyValueType
    {

        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] P
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Q
        {
            get
            {
                return this.qField;
            }
            set
            {
                this.qField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Seed
        {
            get
            {
                return this.seedField;
            }
            set
            {
                this.seedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] PgenCounter
        {
            get
            {
                return this.pgenCounterField;
            }
            set
            {
                this.pgenCounterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyValueType
    {

        private object itemField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyInfoType
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string[] textField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        KeyName,

        /// <remarks/>
        KeyValue,

        /// <remarks/>
        MgmtData,

        /// <remarks/>
        PGPData,

        /// <remarks/>
        RetrievalMethod,

        /// <remarks/>
        SPKIData,

        /// <remarks/>
        X509Data,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    public partial class EncryptionMethodType
    {

        private string keySizeField;

        private byte[] oAEPparamsField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string KeySize
        {
            get
            {
                return this.keySizeField;
            }
            set
            {
                this.keySizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] OAEPparams
        {
            get
            {
                return this.oAEPparamsField;
            }
            set
            {
                this.oAEPparamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EncryptedKeyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EncryptedDataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    public abstract partial class EncryptedType
    {

        private EncryptionMethodType encryptionMethodField;

        private KeyInfoType keyInfoField;

        private CipherDataType cipherDataField;

        private EncryptionPropertiesType encryptionPropertiesField;

        private string idField;

        private string typeField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        public EncryptionMethodType EncryptionMethod
        {
            get
            {
                return this.encryptionMethodField;
            }
            set
            {
                this.encryptionMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        public CipherDataType CipherData
        {
            get
            {
                return this.cipherDataField;
            }
            set
            {
                this.cipherDataField = value;
            }
        }

        /// <remarks/>
        public EncryptionPropertiesType EncryptionProperties
        {
            get
            {
                return this.encryptionPropertiesField;
            }
            set
            {
                this.encryptionPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("EncryptionProperties", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class EncryptionPropertiesType
    {

        private EncryptionPropertyType[] encryptionPropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncryptionProperty")]
        public EncryptionPropertyType[] EncryptionProperty
        {
            get
            {
                return this.encryptionPropertyField;
            }
            set
            {
                this.encryptionPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("EncryptionProperty", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class EncryptionPropertyType
    {

        private System.Xml.XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("EncryptedData", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class EncryptedDataType : EncryptedType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("EncryptedKey", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class EncryptedKeyType : EncryptedType
    {

        private ReferenceList referenceListField;

        private string carriedKeyNameField;

        private string recipientField;

        /// <remarks/>
        public ReferenceList ReferenceList
        {
            get
            {
                return this.referenceListField;
            }
            set
            {
                this.referenceListField = value;
            }
        }

        /// <remarks/>
        public string CarriedKeyName
        {
            get
            {
                return this.carriedKeyNameField;
            }
            set
            {
                this.carriedKeyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class ReferenceList
    {

        private ReferenceType[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataReference", typeof(ReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("KeyReference", typeof(ReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public ReferenceType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        DataReference,

        /// <remarks/>
        KeyReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("AgreementMethod", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class AgreementMethodType
    {

        private byte[] kANonceField;

        private System.Xml.XmlNode[] anyField;

        private KeyInfoType originatorKeyInfoField;

        private KeyInfoType recipientKeyInfoField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KA-Nonce", DataType = "base64Binary")]
        public byte[] KANonce
        {
            get
            {
                return this.kANonceField;
            }
            set
            {
                this.kANonceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType OriginatorKeyInfo
        {
            get
            {
                return this.originatorKeyInfoField;
            }
            set
            {
                this.originatorKeyInfoField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType RecipientKeyInfo
        {
            get
            {
                return this.recipientKeyInfoField;
            }
            set
            {
                this.recipientKeyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    [System.Xml.Serialization.XmlRootAttribute("ConcatKDFParams", Namespace = "http://www.w3.org/2009/xmlenc11#", IsNullable = false)]
    public partial class ConcatKDFParamsType
    {

        private DigestMethodType digestMethodField;

        private byte[] algorithmIDField;

        private byte[] partyUInfoField;

        private byte[] partyVInfoField;

        private byte[] suppPubInfoField;

        private byte[] suppPrivInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] AlgorithmID
        {
            get
            {
                return this.algorithmIDField;
            }
            set
            {
                this.algorithmIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] PartyUInfo
        {
            get
            {
                return this.partyUInfoField;
            }
            set
            {
                this.partyUInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] PartyVInfo
        {
            get
            {
                return this.partyVInfoField;
            }
            set
            {
                this.partyVInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] SuppPubInfo
        {
            get
            {
                return this.suppPubInfoField;
            }
            set
            {
                this.suppPubInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "hexBinary")]
        public byte[] SuppPrivInfo
        {
            get
            {
                return this.suppPrivInfoField;
            }
            set
            {
                this.suppPrivInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DigestMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedKey", Namespace = "http://www.w3.org/2009/xmlenc11#", IsNullable = false)]
    public partial class DerivedKeyType
    {

        private KeyDerivationMethodType keyDerivationMethodField;

        private ReferenceList referenceListField;

        private string derivedKeyNameField;

        private string masterKeyNameField;

        private string recipientField;

        private string idField;

        private string typeField;

        /// <remarks/>
        public KeyDerivationMethodType KeyDerivationMethod
        {
            get
            {
                return this.keyDerivationMethodField;
            }
            set
            {
                this.keyDerivationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
        public ReferenceList ReferenceList
        {
            get
            {
                return this.referenceListField;
            }
            set
            {
                this.referenceListField = value;
            }
        }

        /// <remarks/>
        public string DerivedKeyName
        {
            get
            {
                return this.derivedKeyNameField;
            }
            set
            {
                this.derivedKeyNameField = value;
            }
        }

        /// <remarks/>
        public string MasterKeyName
        {
            get
            {
                return this.masterKeyNameField;
            }
            set
            {
                this.masterKeyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    [System.Xml.Serialization.XmlRootAttribute("KeyDerivationMethod", Namespace = "http://www.w3.org/2009/xmlenc11#", IsNullable = false)]
    public partial class KeyDerivationMethodType
    {

        private System.Xml.XmlElement[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
        private PBKDF2ParameterType pbkParams;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PBKDF2-params")]
        public PBKDF2ParameterType PBKDF2Parameter
        {
            get
            {
                return this.pbkParams;
            }
            set
            {
                this.pbkParams = value;
            }
        }


    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    [System.Xml.Serialization.XmlRootAttribute("PBKDF2-params", Namespace = "http://www.w3.org/2009/xmlenc11#", IsNullable = false)]
    public partial class PBKDF2ParameterType
    {

        private PBKDF2ParameterTypeSalt saltField;

        private string iterationCountField;

        private string keyLengthField;

        private PRFAlgorithmIdentifierType pRFField;

        /// <remarks/>
        public PBKDF2ParameterTypeSalt Salt
        {
            get
            {
                return this.saltField;
            }
            set
            {
                this.saltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string IterationCount
        {
            get
            {
                return this.iterationCountField;
            }
            set
            {
                this.iterationCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string KeyLength
        {
            get
            {
                return this.keyLengthField;
            }
            set
            {
                this.keyLengthField = value;
            }
        }

        /// <remarks/>
        public PRFAlgorithmIdentifierType PRF
        {
            get
            {
                return this.pRFField;
            }
            set
            {
                this.pRFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2009/xmlenc11#")]
    public partial class PBKDF2ParameterTypeSalt
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherSource", typeof(AlgorithmIdentifierType))]
        [System.Xml.Serialization.XmlElementAttribute("Specified", typeof(byte[]), DataType = "base64Binary")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MGFType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PRFAlgorithmIdentifierType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    public partial class AlgorithmIdentifierType
    {

        private object parametersField;

        private string algorithmField;

        /// <remarks/>
        public object Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    public partial class PRFAlgorithmIdentifierType : AlgorithmIdentifierType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2009/xmlenc11#")]
    [System.Xml.Serialization.XmlRootAttribute("MGF", Namespace = "http://www.w3.org/2009/xmlenc11#", IsNullable = false)]
    public partial class MGFType : AlgorithmIdentifierType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private ObjectType[] objectField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public ObjectType[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignedInfoType
    {

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType1[] referenceField;

        private string idField;

        /// <remarks/>
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType1[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class CanonicalizationMethodType
    {

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureMethodType
    {

        private string hMACOutputLengthField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string HMACOutputLength
        {
            get
            {
                return this.hMACOutputLengthField;
            }
            set
            {
                this.hMACOutputLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReferenceType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ReferenceType1
    {

        private TransformType[] transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public DigestMethodType DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ObjectType
    {

        private System.Xml.XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TransformsType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformsType1
    {

        private TransformType[] transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform")]
        public TransformType[] Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ManifestType
    {

        private ReferenceType1[] referenceField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType1[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertiesType
    {

        private SignaturePropertyType[] signaturePropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty
        {
            get
            {
                return this.signaturePropertyField;
            }
            set
            {
                this.signaturePropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertyType
    {

        private System.Xml.XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.nnss.gov/rsl/sim", IsNullable = false)]
    public partial class SimFile
    {

        private SimFileCore baseFileField;

        private SimFileDelta[] supplementalFileField;

        private SignatureType[] signatureField;

        /// <remarks/>
        public SimFileCore BaseFile
        {
            get
            {
                return this.baseFileField;
            }
            set
            {
                this.baseFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplementalFile")]
        public SimFileDelta[] SupplementalFile
        {
            get
            {
                return this.supplementalFileField;
            }
            set
            {
                this.supplementalFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCore
    {

        private string fileFormatVersionField;

        private string fileMinVersionField;

        private SimFileCoreTitle[] titleField;

        private SimFileCoreDescription[] descriptionField;

        private SimFileCoreAuthor authorField;

        private string simVersionField;

        private string simFileUUIDField;

        private SimFileCoreReplaceOnlyWithTrusted replaceOnlyWithTrustedField;

        private SimFileCoreRequireCertificateRevocationChecks requireCertificateRevocationChecksField;

        private MarkedTime startTimeField;

        private MarkedTime stopTimeField;

        private MarkedCert[] trustOnlyRootField;

        private MarkedCert[] intermediateCertsField;

        private SimFileCoreSplashScreen[] splashScreenField;

        private SimFileCoreOnlineUpdates onlineUpdatesField;

        private bool fileEncryptionField;

        private bool fileEncryptionFieldSpecified;

        private SimFileCoreAuthorization[] authorizationField;

        private FieldDataType fieldDataField;

      //  private ObserverDataType observerDataField;

        private byte[] authorDataField;

        private EmbeddedFile[] attachedFilesField;

        private System.Xml.XmlElement[] anyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string FileFormatVersion
        {
            get
            {
                return this.fileFormatVersionField;
            }
            set
            {
                this.fileFormatVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string FileMinVersion
        {
            get
            {
                return this.fileMinVersionField;
            }
            set
            {
                this.fileMinVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public SimFileCoreTitle[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public SimFileCoreDescription[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public SimFileCoreAuthor Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string SimVersion
        {
            get
            {
                return this.simVersionField;
            }
            set
            {
                this.simVersionField = value;
            }
        }

        /// <remarks/>
        public string SimFileUUID
        {
            get
            {
                return this.simFileUUIDField;
            }
            set
            {
                this.simFileUUIDField = value;
            }
        }

        /// <remarks/>
        public SimFileCoreReplaceOnlyWithTrusted ReplaceOnlyWithTrusted
        {
            get
            {
                return this.replaceOnlyWithTrustedField;
            }
            set
            {
                this.replaceOnlyWithTrustedField = value;
            }
        }

        /// <remarks/>
        public SimFileCoreRequireCertificateRevocationChecks RequireCertificateRevocationChecks
        {
            get
            {
                return this.requireCertificateRevocationChecksField;
            }
            set
            {
                this.requireCertificateRevocationChecksField = value;
            }
        }

        /// <remarks/>
        public MarkedTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public MarkedTime StopTime
        {
            get
            {
                return this.stopTimeField;
            }
            set
            {
                this.stopTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrustOnlyRoot")]
        public MarkedCert[] TrustOnlyRoot
        {
            get
            {
                return this.trustOnlyRootField;
            }
            set
            {
                this.trustOnlyRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IntermediateCerts")]
        public MarkedCert[] IntermediateCerts
        {
            get
            {
                return this.intermediateCertsField;
            }
            set
            {
                this.intermediateCertsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplashScreen")]
        public SimFileCoreSplashScreen[] SplashScreen
        {
            get
            {
                return this.splashScreenField;
            }
            set
            {
                this.splashScreenField = value;
            }
        }

        /// <remarks/>
        public SimFileCoreOnlineUpdates OnlineUpdates
        {
            get
            {
                return this.onlineUpdatesField;
            }
            set
            {
                this.onlineUpdatesField = value;
            }
        }

        /// <remarks/>
        public bool FileEncryption
        {
            get
            {
                return this.fileEncryptionField;
            }
            set
            {
                this.fileEncryptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileEncryptionSpecified
        {
            get
            {
                return this.fileEncryptionFieldSpecified;
            }
            set
            {
                this.fileEncryptionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Authorization")]
        public SimFileCoreAuthorization[] Authorization
        {
            get
            {
                return this.authorizationField;
            }
            set
            {
                this.authorizationField = value;
            }
        }

        /// <remarks/>
        public FieldDataType FieldData
        {
            get
            {
                return this.fieldDataField;
            }
            set
            {
                this.fieldDataField = value;
            }
        }
/*
        /// <remarks/>
        public ObserverDataType ObserverData
        {
            get
            {
                return this.observerDataField;
            }
            set
            {
                this.observerDataField = value;
            }
        }
        */
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] AuthorData
        {
            get
            {
                return this.authorDataField;
            }
            set
            {
                this.authorDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachedFiles")]
        public EmbeddedFile[] AttachedFiles
        {
            get
            {
                return this.attachedFilesField;
            }
            set
            {
                this.attachedFilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreTitle
    {

        private string idField;

        private string ietfTagField;

        private string valueField;

        public SimFileCoreTitle()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreDescription
    {

        private string idField;

        private string ietfTagField;

        private string valueField;

        public SimFileCoreDescription()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreAuthor
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreReplaceOnlyWithTrusted
    {

        private string idField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreRequireCertificateRevocationChecks
    {

        private string idField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class MarkedTime
    {

        private string idField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
        public System.DateTime Time
        {
            get
            {
                return valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.String Value
        {
            get
            {
                return this.valueField.ToShortDateString();
            }
            set
            {
                this.valueField = System.DateTime.Parse(value);
                System.Console.WriteLine("Marked Time: " + valueField.ToShortDateString());
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class MarkedCert
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreSplashScreen
    {

        private string splashImageField;

        private string idField;

        private string ietfTagField;

        public SimFileCoreSplashScreen()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string SplashImage
        {
            get
            {
                return this.splashImageField;
            }
            set
            {
                this.splashImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreOnlineUpdates
    {

        private string locationField;

        private bool autoUpdateField;

        private string frequencyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public bool AutoUpdate
        {
            get
            {
                return this.autoUpdateField;
            }
            set
            {
                this.autoUpdateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Frequency
        {
            get
            {
                return this.frequencyField;
            }
            set
            {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileCoreAuthorization
    {

        private string userNameField;

        private Authentication authField;

        private AuthLevel accessField;

        private string idField;

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public Authentication Auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }

        /// <remarks/>
        public AuthLevel Access
        {
            get
            {
                return this.accessField;
            }
            set
            {
                this.accessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PasswordAuth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndividualCert))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoAuth))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PasswordHash))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class Authentication
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PasswordAuth : Authentication
    {

        private DerivedKeyType passwordKeyField;

        private EncryptedKeyType fieldKeyField;

        private EncryptedKeyType observerKeyField;

        private EncryptedKeyType authorKeyField;

        /// <remarks/>
        public DerivedKeyType PasswordKey
        {
            get
            {
                return this.passwordKeyField;
            }
            set
            {
                this.passwordKeyField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType FieldKey
        {
            get
            {
                return this.fieldKeyField;
            }
            set
            {
                this.fieldKeyField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType ObserverKey
        {
            get
            {
                return this.observerKeyField;
            }
            set
            {
                this.observerKeyField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType AuthorKey
        {
            get
            {
                return this.authorKeyField;
            }
            set
            {
                this.authorKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class IndividualCert : Authentication
    {

        private X509IssuerSerialType certNameField;

        private EncryptedKeyType fieldKeyField;

        private EncryptedKeyType observerKeyField;

        private EncryptedKeyType authorKeyField;

        /// <remarks/>
        public X509IssuerSerialType CertName
        {
            get
            {
                return this.certNameField;
            }
            set
            {
                this.certNameField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType FieldKey
        {
            get
            {
                return this.fieldKeyField;
            }
            set
            {
                this.fieldKeyField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType ObserverKey
        {
            get
            {
                return this.observerKeyField;
            }
            set
            {
                this.observerKeyField = value;
            }
        }

        /// <remarks/>
        public EncryptedKeyType AuthorKey
        {
            get
            {
                return this.authorKeyField;
            }
            set
            {
                this.authorKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class NoAuth : Authentication
    {

        private byte[] fieldKeyField;

        private byte[] observerKeyField;

        private byte[] authorKeyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] FieldKey
        {
            get
            {
                return this.fieldKeyField;
            }
            set
            {
                this.fieldKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] ObserverKey
        {
            get
            {
                return this.observerKeyField;
            }
            set
            {
                this.observerKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] AuthorKey
        {
            get
            {
                return this.authorKeyField;
            }
            set
            {
                this.authorKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PasswordHash : Authentication
    {

        private string passwordSaltField;

        private byte[] hashField;

        private string algorithmField;

        public PasswordHash()
        {
            this.algorithmField = "http://www.w3.org/2001/04/xmlenc#sha256";
        }

        /// <remarks/>
        public string PasswordSalt
        {
            get
            {
                return this.passwordSaltField;
            }
            set
            {
                this.passwordSaltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class AuthLevel
    {

        private string idField;

        private UntaggedAuthLevel valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public UntaggedAuthLevel Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public enum UntaggedAuthLevel
    {

        /// <remarks/>
        Field,

        /// <remarks/>
        Oracle,

        /// <remarks/>
        Observer,

        /// <remarks/>
        Author,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class FieldDataType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CipherText", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PlainText", typeof(FieldDataContents))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class FieldDataContents
    {

        private MapType[] mapLayerField;

        private InstrumentLink[] specificInstrumentField;

        private InstrumentType[] instrumentTypeField;

        private RadSrcType[] radiationSourceField;

        private ModelSpectra[] spectraField;

        private FieldTeamType[] fieldTeamField;

        private InjectType[] injectField;

        private WeatherEvents[] weatherField;

        private EmbeddedFile[] fieldFileField;

        private SimPerson[] peopleField;

        private System.Xml.XmlElement[] anyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MapLayer")]
        public MapType[] MapLayer
        {
            get
            {
                return this.mapLayerField;
            }
            set
            {
                this.mapLayerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificInstrument")]
        public InstrumentLink[] SpecificInstrument
        {
            get
            {
                return this.specificInstrumentField;
            }
            set
            {
                this.specificInstrumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstrumentType")]
        public InstrumentType[] InstrumentType
        {
            get
            {
                return this.instrumentTypeField;
            }
            set
            {
                this.instrumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RadiationSource")]
        public RadSrcType[] RadiationSource
        {
            get
            {
                return this.radiationSourceField;
            }
            set
            {
                this.radiationSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spectra")]
        public ModelSpectra[] Spectra
        {
            get
            {
                return this.spectraField;
            }
            set
            {
                this.spectraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FieldTeam")]
        public FieldTeamType[] FieldTeam
        {
            get
            {
                return this.fieldTeamField;
            }
            set
            {
                this.fieldTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Inject")]
        public InjectType[] Inject
        {
            get
            {
                return this.injectField;
            }
            set
            {
                this.injectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weather")]
        public WeatherEvents[] Weather
        {
            get
            {
                return this.weatherField;
            }
            set
            {
                this.weatherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FieldFile")]
        public EmbeddedFile[] FieldFile
        {
            get
            {
                return this.fieldFileField;
            }
            set
            {
                this.fieldFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("People")]
        public SimPerson[] People
        {
            get
            {
                return this.peopleField;
            }
            set
            {
                this.peopleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KMZLayer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WMSLayer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ESRIShapeLayer))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class MapType
    {

        private string layerOrderField;

        private MapTypeVisibleName[] visibleNameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LayerOrder
        {
            get
            {
                return this.layerOrderField;
            }
            set
            {
                this.layerOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisibleName")]
        public MapTypeVisibleName[] VisibleName
        {
            get
            {
                return this.visibleNameField;
            }
            set
            {
                this.visibleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class MapTypeVisibleName
    {

        private string ietfTagField;

        private string valueField;

        public MapTypeVisibleName()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class KMZLayer : MapType
    {

        private string localFileField;

        private PolynomialEquation linearMuField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string LocalFile
        {
            get
            {
                return this.localFileField;
            }
            set
            {
                this.localFileField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation LinearMu
        {
            get
            {
                return this.linearMuField;
            }
            set
            {
                this.linearMuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PolynomialEquation
    {

        private PolynomialPair[] termField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Term")]
        public PolynomialPair[] Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PolynomialPair
    {

        private double coefficientField;

        private double exponentField;

        public PolynomialPair()
        {
            this.exponentField = 0;
        }

        /// <remarks/>
        public double Coefficient
        {
            get
            {
                return this.coefficientField;
            }
            set
            {
                this.coefficientField = value;
            }
        }

        /// <remarks/>
        public double Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class WMSLayer : MapType
    {

        private string webAddressField;

        private string[] layerNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string WebAddress
        {
            get
            {
                return this.webAddressField;
            }
            set
            {
                this.webAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LayerName")]
        public string[] LayerName
        {
            get
            {
                return this.layerNameField;
            }
            set
            {
                this.layerNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ESRIShapeLayer : MapType
    {

        private string sHPFileField;

        private string sHXFileField;

        private string dBFFileField;

        private string pRJFileField;

        private PolynomialEquation linearMuField;

        private string defaultColorField;

        private string widthField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private colorStop[] rampField;

        private string valueFieldField;

        public ESRIShapeLayer()
        {
            this.defaultColorField = "#FF000000";
            this.widthField = "3";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string SHPFile
        {
            get
            {
                return this.sHPFileField;
            }
            set
            {
                this.sHPFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string SHXFile
        {
            get
            {
                return this.sHXFileField;
            }
            set
            {
                this.sHXFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string DBFFile
        {
            get
            {
                return this.dBFFileField;
            }
            set
            {
                this.dBFFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string PRJFile
        {
            get
            {
                return this.pRJFileField;
            }
            set
            {
                this.pRJFileField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation LinearMu
        {
            get
            {
                return this.linearMuField;
            }
            set
            {
                this.linearMuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string DefaultColor
        {
            get
            {
                return this.defaultColorField;
            }
            set
            {
                this.defaultColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IconHref", typeof(string), DataType = "anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("IconLocalFile", typeof(string), DataType = "IDREF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ramp")]
        public colorStop[] Ramp
        {
            get
            {
                return this.rampField;
            }
            set
            {
                this.rampField = value;
            }
        }

        /// <remarks/>
        public string ValueField
        {
            get
            {
                return this.valueFieldField;
            }
            set
            {
                this.valueFieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        IconHref,

        /// <remarks/>
        IconLocalFile,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class colorStop
    {

        private string colorField;

        private float valueField;

        private bool valueFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InstrumentLink
    {

        private string instrumentRefField;

        private string serialNumberField;

        private string gUIDLinkField;

        private TimeDependentFloat[] performanceEffField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string InstrumentRef
        {
            get
            {
                return this.instrumentRefField;
            }
            set
            {
                this.instrumentRefField = value;
            }
        }

        /// <remarks/>
        public string SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public string GUIDLink
        {
            get
            {
                return this.gUIDLinkField;
            }
            set
            {
                this.gUIDLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PerformanceEff")]
        public TimeDependentFloat[] PerformanceEff
        {
            get
            {
                return this.performanceEffField;
            }
            set
            {
                this.performanceEffField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalAnalyticalFloat))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalInterpolatedFloat))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class TimeDependentFloat
    {

        private System.DateTime timePointField;

        private string idField;
                    
        public System.DateTime Time
        {
            get
            {
                return timePointField;
            }
            set
            {
                timePointField = value;
            }
        }
        /// <remarks/>
        public System.String TimePoint
        {
            get
            {
                return this.timePointField.ToShortDateString();
            }
            set
            {
                this.timePointField = System.DateTime.Parse(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class TemporalAnalyticalFloat : TimeDependentFloat
    {

        private PolynomialEquation valueField;

        /// <remarks/>
        public PolynomialEquation Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class TemporalInterpolatedFloat : TimeDependentFloat
    {

        private double valueField;

        /// <remarks/>
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpectralInst))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScalarInst))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class InstrumentType
    {

        private string manufacturerField;

        private string modelField;

        private InstrumentTypeVisibleName[] visibleNameField;

        private float percentErrorField;

        private float percentBiasField;

        private PolynomialEquation gaussianErrorSigmaField;

        private PolynomialEquation deadTimeField;

        private string gUIDisplayField;

        private string idField;

        public InstrumentType()
        {
            this.percentErrorField = ((float)(0F));
            this.percentBiasField = ((float)(0F));
        }

        /// <remarks/>
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisibleName")]
        public InstrumentTypeVisibleName[] VisibleName
        {
            get
            {
                return this.visibleNameField;
            }
            set
            {
                this.visibleNameField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float PercentError
        {
            get
            {
                return this.percentErrorField;
            }
            set
            {
                this.percentErrorField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float PercentBias
        {
            get
            {
                return this.percentBiasField;
            }
            set
            {
                this.percentBiasField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation GaussianErrorSigma
        {
            get
            {
                return this.gaussianErrorSigmaField;
            }
            set
            {
                this.gaussianErrorSigmaField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation DeadTime
        {
            get
            {
                return this.deadTimeField;
            }
            set
            {
                this.deadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string GUIDisplay
        {
            get
            {
                return this.gUIDisplayField;
            }
            set
            {
                this.gUIDisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InstrumentTypeVisibleName
    {

        private string ietfTagField;

        private string valueField;

        public InstrumentTypeVisibleName()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SpectralInst : InstrumentType
    {

        private string minMeasurementTimeField;

        private string maxMeasurementTimeField;

        private PolynomialEquation energyCalibrationField;

        private bool rolloverField;

        private string maxCountsField;

        private string numberChannelsField;

        public SpectralInst()
        {
            this.minMeasurementTimeField = "1";
            this.maxMeasurementTimeField = "600";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MinMeasurementTime
        {
            get
            {
                return this.minMeasurementTimeField;
            }
            set
            {
                this.minMeasurementTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("600")]
        public string MaxMeasurementTime
        {
            get
            {
                return this.maxMeasurementTimeField;
            }
            set
            {
                this.maxMeasurementTimeField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation EnergyCalibration
        {
            get
            {
                return this.energyCalibrationField;
            }
            set
            {
                this.energyCalibrationField = value;
            }
        }

        /// <remarks/>
        public bool Rollover
        {
            get
            {
                return this.rolloverField;
            }
            set
            {
                this.rolloverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxCounts
        {
            get
            {
                return this.maxCountsField;
            }
            set
            {
                this.maxCountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberChannels
        {
            get
            {
                return this.numberChannelsField;
            }
            set
            {
                this.numberChannelsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ScalarInst : InstrumentType
    {

        private float maxValueField;

        private float minValueField;

        private ScalarInstUnits[] unitsField;

        private bool autoScaleField;

        /// <remarks/>
        public float MaxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
            }
        }

        /// <remarks/>
        public float MinValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Units")]
        public ScalarInstUnits[] Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public bool AutoScale
        {
            get
            {
                return this.autoScaleField;
            }
            set
            {
                this.autoScaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ScalarInstUnits
    {

        private string ietfTagField;

        private string valueField;

        public ScalarInstUnits()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class RadSrcType
    {

        private bool airborneField;

        private GeoRegion areaOfEffectField;

        private SourceDistribution spatialDistributionField;

        private Resuspension resuspensionField;

        private string idField;

        /// <remarks/>
        public bool Airborne
        {
            get
            {
                return this.airborneField;
            }
            set
            {
                this.airborneField = value;
            }
        }

        /// <remarks/>
        public GeoRegion AreaOfEffect
        {
            get
            {
                return this.areaOfEffectField;
            }
            set
            {
                this.areaOfEffectField = value;
            }
        }

        /// <remarks/>
        public SourceDistribution SpatialDistribution
        {
            get
            {
                return this.spatialDistributionField;
            }
            set
            {
                this.spatialDistributionField = value;
            }
        }

        /// <remarks/>
        public Resuspension Resuspension
        {
            get
            {
                return this.resuspensionField;
            }
            set
            {
                this.resuspensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicRegion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereRegion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyRegion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CuboidRegion))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class GeoRegion
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ConicRegion : GeoRegion
    {

        private LocationPair axisField;

        private double apexAngleCosField;

        private double altitudeMinimumField;

        private double altitudeMaximumField;

        /// <remarks/>
        public LocationPair Axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }

        /// <remarks/>
        public double ApexAngleCos
        {
            get
            {
                return this.apexAngleCosField;
            }
            set
            {
                this.apexAngleCosField = value;
            }
        }

        /// <remarks/>
        public double AltitudeMinimum
        {
            get
            {
                return this.altitudeMinimumField;
            }
            set
            {
                this.altitudeMinimumField = value;
            }
        }

        /// <remarks/>
        public double AltitudeMaximum
        {
            get
            {
                return this.altitudeMaximumField;
            }
            set
            {
                this.altitudeMaximumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class LocationPair
    {

        private double latitudeField;

        private double longitudeField;

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SphereRegion : GeoRegion
    {

        private LocationTriplet centerField;

        private double radiusField;

        /// <remarks/>
        public LocationTriplet Center
        {
            get
            {
                return this.centerField;
            }
            set
            {
                this.centerField = value;
            }
        }

        /// <remarks/>
        public double Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class LocationTriplet
    {

        private double latitudeField;

        private double longitudeField;

        private double altitudeField;

        public LocationTriplet()
        {
            this.altitudeField = 0;
        }

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(0)]
        public double Altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PolyRegion : GeoRegion
    {

        private double altitudeMinimumField;

        private double altitudeMaximumField;

        private LocationPair[] pointField;

        /// <remarks/>
        public double AltitudeMinimum
        {
            get
            {
                return this.altitudeMinimumField;
            }
            set
            {
                this.altitudeMinimumField = value;
            }
        }

        /// <remarks/>
        public double AltitudeMaximum
        {
            get
            {
                return this.altitudeMaximumField;
            }
            set
            {
                this.altitudeMaximumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public LocationPair[] Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class CuboidRegion : GeoRegion
    {

        private LocationTriplet bottomSouthWestCornerField;

        private LocationTriplet topNorthEastCornerField;

        /// <remarks/>
        public LocationTriplet BottomSouthWestCorner
        {
            get
            {
                return this.bottomSouthWestCornerField;
            }
            set
            {
                this.bottomSouthWestCornerField = value;
            }
        }

        /// <remarks/>
        public LocationTriplet TopNorthEastCorner
        {
            get
            {
                return this.topNorthEastCornerField;
            }
            set
            {
                this.topNorthEastCornerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BackgroundSource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridSource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSource))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class SourceDistribution
    {

        private InstrumentEfficiency[] instrumentResponseField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstrumentResponse")]
        public InstrumentEfficiency[] InstrumentResponse
        {
            get
            {
                return this.instrumentResponseField;
            }
            set
            {
                this.instrumentResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InstrumentEfficiency
    {

        private string instrumentRefField;

        private TimeEfficiency[] effCurvesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string InstrumentRef
        {
            get
            {
                return this.instrumentRefField;
            }
            set
            {
                this.instrumentRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EffCurves")]
        public TimeEfficiency[] EffCurves
        {
            get
            {
                return this.effCurvesField;
            }
            set
            {
                this.effCurvesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class TimeEfficiency
    {

        private System.DateTime asOfField;

        private object itemField;
        public System.DateTime AsOfTime
        {
            get
            {
                return asOfField;
            }
            set
            {
                asOfField = value;
            }
        }
        /// <remarks/>
        public System.String AsOf
        {
            
            get
            {
                return this.asOfField.ToShortDateString();
            }
            set
            {
                this.asOfField = System.DateTime.Parse(value);
                System.Console.WriteLine("AsOf Time: " + asOfField.ToLongDateString());
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnalyticalDistance", typeof(AnalyticalDistanceEfficiency))]
        [System.Xml.Serialization.XmlElementAttribute("InterpolatedDistance", typeof(InterpolatedDistanceEfficiency))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class GridSource : SourceDistribution
    {
        private GeoRegion boundsField;

        private string interpolationOrderField;

        private System.DateTime zeroStartTimeField;

        private string uTMZoneField;

        private GridValues[] distributionField;

        double[] xValues;
        double[] yValues;

        public GridSource()
        {
            this.uTMZoneField = "0";
            this.interpolationOrderField = "1";
        }

        /// <remarks/>
        public GeoRegion Bounds
        {
            get
            {
                return this.boundsField;
            }
            set
            {
                this.boundsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string UTMZone
        {
            get
            {
                return this.uTMZoneField;
            }
            set
            {
                this.uTMZoneField = value;
            }
        }

        /// <remarks/>
        public string XCoordinates
        {
            get
            {
                return gov.nnss.rsl.xsim.impl.Utilities.FPList(this.xValues);
            }
            set
            {
                this.xValues = gov.nnss.rsl.xsim.impl.Utilities.listParser(value);
            }
        }

        /// <remarks/>
        public string YCoordinates
        {
            get
            {
                return gov.nnss.rsl.xsim.impl.Utilities.FPList(this.yValues);
            }
            set
            {
                this.yValues = gov.nnss.rsl.xsim.impl.Utilities.listParser(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string InterpolationOrder
        {
            get
            {
                return this.interpolationOrderField;
            }
            set
            {
                this.interpolationOrderField = value;
            }
        }
        
        /// <remarks/>
        
        [System.Xml.Serialization.XmlElementAttribute]
        public System.String ZeroStartTime
        {
            get
            {
                return this.zeroStartTimeField.ToShortDateString();
            }
            set
            {
                System.Console.WriteLine("Trying zeroStartTime");
                this.zeroStartTimeField = System.DateTime.Parse(value);
                System.Console.WriteLine("ZeroStartTime :" + zeroStartTimeField.ToLongDateString());
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public GridValues[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }
        public System.DateTime ZeroTime
        {
            get
            {
                return zeroStartTimeField;
            }
            set
            {
                zeroStartTimeField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class GridValues
    {

        private System.DateTime timePointField;

        private bool timePointFieldSpecified;

        private GridSource[] subGridField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Values")]
        public string[] Values
        {

            get
            {
                string[] sValues = new string[fValues.GetLength(0)];
                int i = 0;
                foreach (double[] aFArray in fValues)
                {
                    sValues[i] = gov.nnss.rsl.xsim.impl.Utilities.FPList(aFArray);
                    i++;
                }
                return sValues;
            }
            set
            {
                this.fValues = new double[value.GetLength(0)][];
                int i = 0;
                foreach (System.String aLine in value)
                {
                    fValues[i] = gov.nnss.rsl.xsim.impl.Utilities.listParser(aLine);
                    i++;

                }
            }
        }
        public System.DateTime Time
        {
            get
            {
                return timePointField;
            }
            set
            {
                timePointField = value;
            }
        }
        /// <remarks/>
        public System.String TimePoint
        {
            get
            {
                return this.timePointField.ToShortDateString();
            }
            set
            {
                this.timePointField = System.DateTime.Parse(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimePointSpecified
        {
            get
            {
                return this.timePointFieldSpecified;
            }
            set
            {
                this.timePointFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubGrid")]
        public GridSource[] SubGrid
        {
            get
            {
                return this.subGridField;
            }
            set
            {
                this.subGridField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ModelSpectra
    {
        private static System.Collections.Generic.Dictionary<string, ModelSpectra> parsedSpectra = null;
        public static ModelSpectra GetSpectraByID(string id)
        {
            if (parsedSpectra == null)
            {
                return null;
            }
            return parsedSpectra[id];
        }

        private double[] channelsField;

        private string idField;

        public double[] getFPChannels()
        {
            return channelsField;
        }
        /// <remarks/>
        public string Channels
        {
            get
            {
                return gov.nnss.rsl.xsim.impl.Utilities.FPList(channelsField);
            }
            set
            {
                channelsField = gov.nnss.rsl.xsim.impl.Utilities.listParser(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                if(parsedSpectra == null) parsedSpectra = new System.Collections.Generic.Dictionary<string, ModelSpectra>();
                parsedSpectra.Add(idField, this);

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class AnalyticalDistanceEfficiency
    {

        private PolynomialEquation[] effCurveField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EffCurve")]
        public PolynomialEquation[] EffCurve
        {
            get
            {
                return this.effCurveField;
            }
            set
            {
                this.effCurveField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InterpolatedDistanceEfficiency
    {

  //      private string distancesField;

        private uint orderField;

        private object[] itemsField;

        public InterpolatedDistanceEfficiency()
        {
            this.orderField = ((uint)(1));
        }
        /*
        /// <remarks/>
        public string Distances
        {
            get
            {
                return this.distancesField;
            }
            set
            {
                this.distancesField = value;
            }
        }
        */
        /// <remarks/>
        public uint Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
   //     [XmlIgnoreAttribute]
     //   public ItemChoiceType ItemType;
        [XmlType(IncludeInSchema=false)]
        public enum ItemsChoiceType
        {
            Efficiencies,
            Spectra,
            SpectraRef
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Efficiencies", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Spectra", typeof(ModelSpectra))]
        [System.Xml.Serialization.XmlElementAttribute("SpectraRef", typeof(string), DataType = "IDREF")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
    }
    /*
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ModelSpectra
    {

        private string channelsField;

        private string idField;

        /// <remarks/>
        public string Channels
        {
            get
            {
                return this.channelsField;
            }
            set
            {
                this.channelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }
    */
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class BackgroundSource : SourceDistribution
    {

        private BackgroundSourceType typeField;

        private TimeDependentFloat[] arealActivityField;

        private float randomizationMagnitudeField;

        public BackgroundSource()
        {
            this.randomizationMagnitudeField = ((float)(10F));
        }

        /// <remarks/>
        public BackgroundSourceType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArealActivity")]
        public TimeDependentFloat[] ArealActivity
        {
            get
            {
                return this.arealActivityField;
            }
            set
            {
                this.arealActivityField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "10")]
        public float RandomizationMagnitude
        {
            get
            {
                return this.randomizationMagnitudeField;
            }
            set
            {
                this.randomizationMagnitudeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public enum BackgroundSourceType
    {

        /// <remarks/>
        Constant,

        /// <remarks/>
        RandomizedLinear,

        /// <remarks/>
        RandomizedGaussian,
    }
   
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class PointSource : SourceDistribution
    {

        private Location[] locationField;

        private TimeDependentFloat[] activityField;

        private bool wGS84AltitudeField;

        public PointSource()
        {
            this.wGS84AltitudeField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public Location[] Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Activity")]
        public TimeDependentFloat[] Activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }

        /// <remarks/>
        public bool WGS84Altitude
        {
            get
            {
                return this.wGS84AltitudeField;
            }
            set
            {
                this.wGS84AltitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeDependentAnalyticalLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HardwareRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FixedLocation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class Location
    {

        private System.DateTime timePointField;
        public System.DateTime Time
        {
            get
            {
                return timePointField;
            }
            set
            {
                timePointField = value;
            }
        }
        /// <remarks/>
        public System.String TimePoint
        {
            get
            {
                return this.timePointField.ToShortDateString();
            }
            set
            {
                this.timePointField = System.DateTime.Parse(value);
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class TimeDependentAnalyticalLocation : Location
    {

        private PolynomialEquation latitudeField;

        private PolynomialEquation longitudeField;

        private PolynomialEquation altitudeField;

        /// <remarks/>
        public PolynomialEquation Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public PolynomialEquation Altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class HardwareRef : Location
    {

        private string referenceField;

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class FixedLocation : Location
    {

        private LocationTriplet locationPointField;

        /// <remarks/>
        public LocationTriplet LocationPoint
        {
            get
            {
                return this.locationPointField;
            }
            set
            {
                this.locationPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NcrpResuspension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaxwellAnspaughResuspension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModifiedAnspaughResuspension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnspaughResuspension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstantResuspension))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public abstract partial class Resuspension
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class NcrpResuspension : Resuspension
    {

        private System.DateTime startTimeField;

        /// <remarks/>
        public System.String StartTime
        {
            get
            {
                return this.startTimeField.ToShortDateString();
            }
            set
            {
                this.startTimeField = System.DateTime.Parse(value);
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class MaxwellAnspaughResuspension : Resuspension
    {

        private System.DateTime startTimeField;

        /// <remarks/>
        public System.String StartTime
        {
            get
            {
                return this.startTimeField.ToShortDateString();
            }
            set
            {
                this.startTimeField = System.DateTime.Parse(value);
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ModifiedAnspaughResuspension : Resuspension
    {

        private System.DateTime startTimeField;

        /// <remarks/>
        public System.String StartTime
        {
            
            get
            {
                return this.startTimeField.ToShortDateString();
            }
            set
            {
                this.startTimeField = System.DateTime.Parse(value);
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class AnspaughResuspension : Resuspension
    {

        private System.DateTime startTimeField;

        /// <remarks/>
        public System.String StartTime
        {
            get
            {
                return this.startTimeField.ToShortDateString();
            }
            set
            {
                this.startTimeField = System.DateTime.Parse(value);
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class ConstantResuspension : Resuspension
    {

        private float dryField;

        private float wetField;

        /// <remarks/>
        public float Dry
        {
            get
            {
                return this.dryField;
            }
            set
            {
                this.dryField = value;
            }
        }

        /// <remarks/>
        public float Wet
        {
            get
            {
                return this.wetField;
            }
            set
            {
                this.wetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class FieldTeamType
    {

        private string nameField;

        private string teamLeaderField;

        private string[] teamMemberField;

        private string[] instrumentField;

        private string idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string TeamLeader
        {
            get
            {
                return this.teamLeaderField;
            }
            set
            {
                this.teamLeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TeamMember", DataType = "IDREF")]
        public string[] TeamMember
        {
            get
            {
                return this.teamMemberField;
            }
            set
            {
                this.teamMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Instrument", DataType = "IDREF")]
        public string[] Instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InjectType
    {

        private InjectTypeTitle[] titleField;

        private System.DateTime injectTimeField;

        private bool lateInjectionField;

        private UntaggedAuthLevel authorizationLevelField;

        private string overrideLevelField;

        private bool autoplayMultimediaField;

        private InjectTypeFile[] fileField;

        private string sourcePersonField;

        private GeoRegion locationField;

        private string idField;

        public InjectType()
        {
            this.authorizationLevelField = UntaggedAuthLevel.Field;
            this.overrideLevelField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public InjectTypeTitle[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        public System.DateTime Time
        {
            get
            {
                return injectTimeField;
            }
            set
            {
                injectTimeField = value;
            }
        }
        /// <remarks/>
        public System.String InjectTime
        {
            
            get
            {
                return this.injectTimeField.ToShortDateString();
            }
            set
            {
                this.injectTimeField = System.DateTime.Parse(value);
            }
            
        }

        /// <remarks/>
        public bool LateInjection
        {
            get
            {
                return this.lateInjectionField;
            }
            set
            {
                this.lateInjectionField = value;
            }
        }

        /// <remarks/>
        public UntaggedAuthLevel AuthorizationLevel
        {
            get
            {
                return this.authorizationLevelField;
            }
            set
            {
                this.authorizationLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string OverrideLevel
        {
            get
            {
                return this.overrideLevelField;
            }
            set
            {
                this.overrideLevelField = value;
            }
        }

        /// <remarks/>
        public bool AutoplayMultimedia
        {
            get
            {
                return this.autoplayMultimediaField;
            }
            set
            {
                this.autoplayMultimediaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File")]
        public InjectTypeFile[] File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string SourcePerson
        {
            get
            {
                return this.sourcePersonField;
            }
            set
            {
                this.sourcePersonField = value;
            }
        }

        /// <remarks/>
        public GeoRegion Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InjectTypeTitle
    {

        private string idField;

        private string ietfTagField;

        private string valueField;

        public InjectTypeTitle()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class InjectTypeFile
    {

        private string idField;

        private string ietfTagField;

        private string valueField;

        public InjectTypeFile()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "IDREF")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class WeatherEvents
    {

        private WeatherEventsType[] typeField;

        private GeoRegion regionField;

        private string overrideLevelField;

        private MarkedTime startField;

        private MarkedTime endField;

        private float precipitationRateField;

        private string idField;

        public WeatherEvents()
        {
            this.overrideLevelField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type")]
        public WeatherEventsType[] Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public GeoRegion Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string OverrideLevel
        {
            get
            {
                return this.overrideLevelField;
            }
            set
            {
                this.overrideLevelField = value;
            }
        }

        /// <remarks/>
        public MarkedTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        public MarkedTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public float PrecipitationRate
        {
            get
            {
                return this.precipitationRateField;
            }
            set
            {
                this.precipitationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class WeatherEventsType
    {

        private string idField;

        private string ietfTagField;

        private string valueField;

        public WeatherEventsType()
        {
            this.ietfTagField = "en-us";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("en-us")]
        public string ietfTag
        {
            get
            {
                return this.ietfTagField;
            }
            set
            {
                this.ietfTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class EmbeddedFile
    {

        private string fileNameField;

        private string mimeTypeField;

        private byte[] dataField;

        private string idField;

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimPerson
    {

        private string firstNameField;

        private string lastNameField;

        private string phoneNumberField;

        private string eMailAddressField;

        private string userPhotoField;

        private string accessAuthorizationField;

        private string idField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }

        /// <remarks/>
        public string EMailAddress
        {
            get
            {
                return this.eMailAddressField;
            }
            set
            {
                this.eMailAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string UserPhoto
        {
            get
            {
                return this.userPhotoField;
            }
            set
            {
                this.userPhotoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string AccessAuthorization
        {
            get
            {
                return this.accessAuthorizationField;
            }
            set
            {
                this.accessAuthorizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class SimFileDelta
    {

        private string priorFileUUIDField;

        private string priorVersionField;

        private string newVersionField;

        private string[] nodeToDeleteField;

        private NewContent unencryptedContentField;

        private byte[] encryptedFieldContentField;

        private byte[] encryptedAuthorContentField;

        private string idField;

        /// <remarks/>
        public string PriorFileUUID
        {
            get
            {
                return this.priorFileUUIDField;
            }
            set
            {
                this.priorFileUUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string PriorVersion
        {
            get
            {
                return this.priorVersionField;
            }
            set
            {
                this.priorVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NewVersion
        {
            get
            {
                return this.newVersionField;
            }
            set
            {
                this.newVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NodeToDelete", DataType = "IDREF")]
        public string[] NodeToDelete
        {
            get
            {
                return this.nodeToDeleteField;
            }
            set
            {
                this.nodeToDeleteField = value;
            }
        }

        /// <remarks/>
        public NewContent UnencryptedContent
        {
            get
            {
                return this.unencryptedContentField;
            }
            set
            {
                this.unencryptedContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] EncryptedFieldContent
        {
            get
            {
                return this.encryptedFieldContentField;
            }
            set
            {
                this.encryptedFieldContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] EncryptedAuthorContent
        {
            get
            {
                return this.encryptedAuthorContentField;
            }
            set
            {
                this.encryptedAuthorContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class NewContent
    {

        private object[] nodeToReplaceField;

        private NewContentNodesToInsert[] nodesToInsertField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NodeToReplace")]
        public object[] NodeToReplace
        {
            get
            {
                return this.nodeToReplaceField;
            }
            set
            {
                this.nodeToReplaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NodesToInsert")]
        public NewContentNodesToInsert[] NodesToInsert
        {
            get
            {
                return this.nodesToInsertField;
            }
            set
            {
                this.nodesToInsertField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nnss.gov/rsl/sim")]
    public partial class NewContentNodesToInsert
    {

        private string parentNodeField;

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string ParentNode
        {
            get
            {
                return this.parentNodeField;
            }
            set
            {
                this.parentNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
}
