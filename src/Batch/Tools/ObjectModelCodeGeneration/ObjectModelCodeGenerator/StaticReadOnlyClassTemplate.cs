﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ObjectModelCodeGenerator
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using CodeGenerationLibrary;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class StaticReadOnlyClassTemplate : StaticReadOnlyClassTemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("    /// <summary>\r\n");
            this.Write(this.ToStringHelper.ToStringWithCulture(CommentUtilities.FormatTripleSlashComment(type.Comment, CommentUtilities.Indentation.TypeLevel)));
            this.Write("\r\n    /// </summary>\r\n    public partial class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write(" :");
 if(type.ShouldDefineGetTransportObject) { 
            this.Write(" ITransportObjectProvider<");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.TransportObjectTypeName));
            this.Write(">,");
 } 
            this.Write(" IPropertyMetadata\r\n    {\r\n");

foreach (var property in type.OrderedPublicProperties.Select(p => p.Key))
{

            this.Write("        private readonly ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            this.Write(" ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            this.Write(";\r\n");

}

            this.Write("\r\n        #region Constructors\r\n");
 if (type.ShouldDefineCustomConstructor)
{

            this.Write("        /// <summary>\r\n        /// Initializes a new instance of the <see cref=\"");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write("\"/> class.\r\n        /// </summary>\r\n");

    foreach (var property in type.ConstructorProperties)
    {

            this.Write("        /// <param name=\'");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            this.Write("\'>");
            this.Write(this.ToStringHelper.ToStringWithCulture(CommentUtilities.FormatTripleSlashComment(property.SummaryComment, CommentUtilities.Indentation.TypeMemberLevel, false)));
            this.Write("</param>\r\n");

    }

            this.Write("        ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.ConstructorVisibilityString));
            this.Write(" ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write("(");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.GetCustomConstructorParametersString(CommentUtilities.Indentation.TabSizeInSpaces * 3)));
            this.Write(")\r\n        {\r\n");

    foreach (var property in type.ConstructorProperties)
    {

            this.Write("            this.");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            this.Write(" = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            this.Write(";\r\n");

    }

            this.Write("        }\r\n");

}

            this.Write("\r\n        internal ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write("(");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.GetBoundConstructorParameterString(CommentUtilities.Indentation.TabSizeInSpaces * 3)));
            this.Write(")\r\n        {\r\n");

foreach (var kvp in type.BoundProperties)
{
    var protocolObjectGetter = CodeGenerationUtilities.GetProtocolToObjectModelString(kvp.Key, kvp.Value);

            this.Write("            this.");
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key.CamelName));
            this.Write(" = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(protocolObjectGetter));
            this.Write(";\r\n");

}

            this.Write("        }\r\n\r\n        #endregion Constructors\r\n\r\n        #region ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write("\r\n\r\n");

foreach (var property in type.OrderedPublicProperties.Select(p => p.Key))
{

            this.Write("        /// <summary>\r\n");
            this.Write(this.ToStringHelper.ToStringWithCulture(CommentUtilities.FormatTripleSlashComment(property.FullSummaryComment, CommentUtilities.Indentation.TypeMemberLevel)));
            this.Write("\r\n        /// </summary>\r\n");

if (!string.IsNullOrEmpty(property.RemarksComment))
{

            this.Write("        /// <remarks>\r\n");
            this.Write(this.ToStringHelper.ToStringWithCulture(CommentUtilities.FormatTripleSlashComment(property.RemarksComment, CommentUtilities.Indentation.TypeMemberLevel)));
            this.Write("\r\n        /// </remarks>\r\n");

}

            this.Write("        public ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            this.Write(" ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            this.Write("\r\n        {\r\n            get { return this.");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            this.Write("; }\r\n        }\r\n\r\n");

}

            this.Write("        #endregion // ");
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            this.Write(@"

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
");

string transportObjectText = (new GetTransportObjectSnippet(type)).TransformText();
string collectionConversionText = (new CollectionConversionSnippet(type)).TransformText();
if (!string.IsNullOrEmpty(transportObjectText) || !string.IsNullOrEmpty(collectionConversionText))
{

            this.Write("\r\n        #region Internal/private methods\r\n\r\n");
            this.Write(this.ToStringHelper.ToStringWithCulture(transportObjectText));
            this.Write("\r\n");
            this.Write(this.ToStringHelper.ToStringWithCulture(collectionConversionText));
            this.Write("\r\n        #endregion // Internal/private methods\r\n");

}

            this.Write("    }");
            return this.GenerationEnvironment.ToString();
        }

private global::CodeGenerationLibrary.ObjectModelTypeData _typeField;

/// <summary>
/// Access the type parameter of the template.
/// </summary>
private global::CodeGenerationLibrary.ObjectModelTypeData type
{
    get
    {
        return this._typeField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool typeValueAcquired = false;
if (this.Session.ContainsKey("type"))
{
    this._typeField = ((global::CodeGenerationLibrary.ObjectModelTypeData)(this.Session["type"]));
    typeValueAcquired = true;
}
if ((typeValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("type");
    if ((data != null))
    {
        this._typeField = ((global::CodeGenerationLibrary.ObjectModelTypeData)(data));
    }
}


    }
}


    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class StaticReadOnlyClassTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}