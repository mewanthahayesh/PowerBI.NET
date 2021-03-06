﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCommon.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PowerResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PowerResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ServiceCommon.Resources.PowerResource", typeof(PowerResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No reports were found in the workspace..
        /// </summary>
        public static string EmbedReportNotFoundError {
            get {
                return ResourceManager.GetString("EmbedReportNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WebApi Url defined for report..
        /// </summary>
        public static string EmbedReportUrlIsMissingError {
            get {
                return ResourceManager.GetString("EmbedReportUrlIsMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application Id in User request is missing or not defined..
        /// </summary>
        public static string ValidationError_ApplicationIdMissing {
            get {
                return ResourceManager.GetString("ValidationError_ApplicationIdMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication is in error..
        /// </summary>
        public static string ValidationError_AuthenticationError {
            get {
                return ResourceManager.GetString("ValidationError_AuthenticationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No client workspace defined in the request..
        /// </summary>
        public static string ValidationError_ClientWorkSpaceMissingForClone {
            get {
                return ResourceManager.GetString("ValidationError_ClientWorkSpaceMissingForClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No report defined for embedding..
        /// </summary>
        public static string ValidationError_EmbedReportsMissingError {
            get {
                return ResourceManager.GetString("ValidationError_EmbedReportsMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No workspace defined in the request..
        /// </summary>
        public static string ValidationError_EmbedWorkSpaceMissingForClone {
            get {
                return ResourceManager.GetString("ValidationError_EmbedWorkSpaceMissingForClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parent report name defined in the collection for cloning..
        /// </summary>
        public static string ValidationError_ParentReportsNameMissingForClone {
            get {
                return ResourceManager.GetString("ValidationError_ParentReportsNameMissingForClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No parent workspace defined in the request..
        /// </summary>
        public static string ValidationError_ParentWorkSpaceMissingForClone {
            get {
                return ResourceManager.GetString("ValidationError_ParentWorkSpaceMissingForClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No report defined in the collection for cloning..
        /// </summary>
        public static string ValidationError_ReportsMissingForClone {
            get {
                return ResourceManager.GetString("ValidationError_ReportsMissingForClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secret Id in User request is missing or not defined..
        /// </summary>
        public static string ValidationError_SecretIdMissing {
            get {
                return ResourceManager.GetString("ValidationError_SecretIdMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tenant Id in User request is missing or not defined..
        /// </summary>
        public static string ValidationError_TenantIdMissing {
            get {
                return ResourceManager.GetString("ValidationError_TenantIdMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client group can not be found..
        /// </summary>
        public static string ValidationErrorClientGroupNotFoundError {
            get {
                return ResourceManager.GetString("ValidationErrorClientGroupNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credential not  defined for embedding..
        /// </summary>
        public static string ValidationErrorCredentialMissingError {
            get {
                return ResourceManager.GetString("ValidationErrorCredentialMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parent group can not be found..
        /// </summary>
        public static string ValidationErrorParentGroupNotFoundError {
            get {
                return ResourceManager.GetString("ValidationErrorParentGroupNotFoundError", resourceCulture);
            }
        }
    }
}
